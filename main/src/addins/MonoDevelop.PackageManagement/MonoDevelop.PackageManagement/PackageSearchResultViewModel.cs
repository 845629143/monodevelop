﻿//
// PackageSearchResultViewModel.cs
//
// Author:
//       Matt Ward <matt.ward@xamarin.com>
//
// Copyright (c) 2016 Xamarin Inc. (http://xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MonoDevelop.Core;
using NuGet.PackageManagement.UI;
using NuGet.Frameworks;
using NuGet.Versioning;

namespace MonoDevelop.PackageManagement
{
	internal class PackageSearchResultViewModel : ViewModelBase<PackageSearchResultViewModel>
	{
		AllPackagesViewModel parent;
		PackageItemListViewModel viewModel;
		PackageDetailControlModel packageDetailModel;
		List<PackageDependencyMetadata> dependencies;
		bool isChecked;

		public PackageSearchResultViewModel (
			AllPackagesViewModel parent,
			PackageItemListViewModel viewModel)
		{
			this.parent = parent;
			this.viewModel = viewModel;

			Versions = new ObservableCollection<NuGetVersion> ();
			SelectedVersion = Version;
		}

		public string Id {
			get { return viewModel.Id; }
		}

		public NuGetVersion Version {
			get { return viewModel.Version; }
		}

		public string Title {
			get { return viewModel.Title; }
		}

		public string Name {
			get {
				if (String.IsNullOrEmpty (Title))
					return Id;

				return Title;
			}
		}

		public bool IsChecked {
			get { return isChecked; }
			set {
				if (value != isChecked) {
					isChecked = value;
					parent.OnPackageCheckedChanged (this);
				}
			}
		}

		public bool HasLicenseUrl {
			get { return LicenseUrl != null; }
		}

		public Uri LicenseUrl {
			get { return viewModel.LicenseUrl; }
		}

		public bool HasProjectUrl {
			get { return ProjectUrl != null; }
		}

		public Uri ProjectUrl {
			get { return viewModel.ProjectUrl; }
		}

		public bool HasGalleryUrl {
			get { return GalleryUrl != null; }
		}

		public bool HasNoGalleryUrl {
			get { return !HasGalleryUrl; }
		}

		public Uri GalleryUrl {
			get { return null; }
			//get { return viewModel.GalleryUrl; }
		}

		public Uri IconUrl {
			get { return viewModel.IconUrl; }
		}

		public bool HasIconUrl {
			get { return IconUrl != null; }
		}

		public string Author {
			get { return viewModel.Author; }
		}

		public string Summary {
			get { return viewModel.Summary; }
		}

		public string Description {
			get { return viewModel.Description; }
		}

		public bool HasDownloadCount {
			get { return viewModel.DownloadCount >= 0; }
		}

		public string GetNameMarkup ()
		{
			return GetBoldText (Name);
		}

		static string GetBoldText (string text)
		{
			return String.Format ("<b>{0}</b>", text);
		}

		public string GetDownloadCountOrVersionDisplayText ()
		{
			if (ShowVersionInsteadOfDownloadCount) {
				return Version.ToString ();
			}

			return GetDownloadCountDisplayText ();
		}

		public string GetDownloadCountDisplayText ()
		{
			if (HasDownloadCount) {
				return viewModel.DownloadCount.Value.ToString ("N0");
			}
			return String.Empty;
		}

		public bool ShowVersionInsteadOfDownloadCount { get; set; }

		public DateTimeOffset? LastPublished {
			get { return viewModel.Published; }
		}

		public bool HasLastPublished {
			get { return viewModel.Published.HasValue; }
		}

		public string GetLastPublishedDisplayText()
		{
			if (HasLastPublished) {
				return LastPublished.Value.Date.ToShortDateString ();
			}
			return String.Empty;
		}

		public NuGetVersion SelectedVersion { get; set; }
		public ObservableCollection<NuGetVersion> Versions { get; private set; }

		public void ReadVersions ()
		{
			try {
				packageDetailModel = new PackageDetailControlModel (parent.NuGetProject);
				packageDetailModel.SelectedVersion = new DisplayVersion (SelectedVersion, null);
				packageDetailModel.SetCurrentPackage (viewModel).ContinueWith (
					task => OnVersionsRead (task),
					TaskScheduler.FromCurrentSynchronizationContext ());
			} catch (Exception ex) {
				LoggingService.LogError ("ReadVersions error.", ex);
			}
		}

		void OnVersionsRead (Task task)
		{
			try {
				if (task.IsFaulted) {
					LoggingService.LogError ("Failed to read package versions.", task.Exception);
				} else if (task.IsCanceled) {
					// Ignore.
				} else {
					Versions.Clear ();
					foreach (NuGetVersion version in packageDetailModel.AllPackageVersions.OrderByDescending (v => v.Version)) {
						Versions.Add (version);
					}
					OnPropertyChanged (viewModel => viewModel.Versions);
				}
			} catch (Exception ex) {
				LoggingService.LogError ("Failed to read package versions.", ex);
			}
		}

		public bool IsOlderPackageInstalled ()
		{
			return parent.IsOlderPackageInstalled (Id, SelectedVersion);
		}

		public override bool Equals (object obj)
		{
			var other = obj as PackageSearchResultViewModel;
			if (other == null)
				return false;

			return StringComparer.OrdinalIgnoreCase.Equals (Id, other.Id);
		}

		public override int GetHashCode ()
		{
			return Id.GetHashCode ();
		}

		public void UpdateFromPreviouslyCheckedViewModel (PackageSearchResultViewModel packageViewModel)
		{
			IsChecked = packageViewModel.IsChecked;
			SelectedVersion = packageViewModel.SelectedVersion;
			if (SelectedVersion != Version) {
				Versions.Add (Version);
				Versions.Add (SelectedVersion);
			}
		}

		public void LoadPackageMetadata (IPackageMetadataProvider metadataProvider, CancellationToken token)
		{
			try {
				packageDetailModel.LoadPackageMetadaAsync (metadataProvider, token).ContinueWith (
					task => OnPackageMetadataLoaded (task),
					TaskScheduler.FromCurrentSynchronizationContext ());
			} catch (Exception ex) {
				LoggingService.LogError ("Error getting detailed package metadata.", ex);
			}
		}

		void OnPackageMetadataLoaded (Task task)
		{
			try {
				if (task.IsFaulted) {
					LoggingService.LogError ("Failed to read package metadata.", task.Exception);
				} else if (task.IsCanceled) {
					// Ignore.
				} else {
					var metadata = packageDetailModel?.PackageMetadata;
					if (metadata != null) {
						viewModel.Published = metadata.Published;
						OnPropertyChanged ("Dependencies");
					}
				}
			} catch (Exception ex) {
				LoggingService.LogError ("Failed to read package metadata.", ex);
			}
		}

		public bool HasDependencies {
			get { return CompatibleDependencies.Any (); }
		}

		public bool HasNoDependencies {
			get { return !HasDependencies; }
		}

		public string GetPackageDependenciesDisplayText ()
		{
			var displayText = new StringBuilder ();
			foreach (PackageDependencyMetadata dependency in CompatibleDependencies) {
				displayText.AppendLine (dependency.ToString ());
			}
			return displayText.ToString ();
		}

		public IEnumerable<PackageDependencyMetadata> CompatibleDependencies {
			get {
				if (dependencies == null) {
					dependencies = GetCompatibleDependencies ().ToList ();
				}
				return dependencies;
			}
		}

		IEnumerable<PackageDependencyMetadata> GetCompatibleDependencies ()
		{
			var metadata = packageDetailModel?.PackageMetadata;
			if (metadata?.HasDependencies == true) {
				var projectTargetFramework = new ProjectTargetFramework (parent.Project);
				var targetFramework = NuGetFramework.Parse (projectTargetFramework.TargetFrameworkName.FullName);

				foreach (var dependencySet in packageDetailModel.PackageMetadata.DependencySets) {
					if (DefaultCompatibilityProvider.Instance.IsCompatible (targetFramework, dependencySet.TargetFramework)) {
						return dependencySet.Dependencies;
					}
				}
			}

			return Enumerable.Empty<PackageDependencyMetadata> ();
		}
	}
}

