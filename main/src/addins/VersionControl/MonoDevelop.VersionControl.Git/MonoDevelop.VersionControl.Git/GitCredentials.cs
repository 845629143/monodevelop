// 
// GitCredentials.cs
//  
// Author:
//       Lluis Sanchez Gual <lluis@novell.com>
// 
// Copyright (c) 2010 Novell, Inc (http://www.novell.com)
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
using System.Linq;

using MonoDevelop.Core;
using MonoDevelop.Ide;
using NGit.Transport;

namespace MonoDevelop.VersionControl.Git
{
	public class GitCredentials: CredentialsProvider
	{
		public override bool IsInteractive ()
		{
			return true;
		}
		
		public override bool Supports (params CredentialItem[] items)
		{
			return true;
		}
		
		public override bool Get (URIish uri, params CredentialItem[] items)
		{
			bool result = false;
			var username = (CredentialItem.Username) items.First (i => i is CredentialItem.Username);
			var password = (CredentialItem.Password) items.First (i => i is CredentialItem.Password);
			
			if (username != null && password != null && TryGetFromPasswordService (uri, username, password))
				return true;
			
			DispatchService.GuiSyncDispatch (delegate {
				CredentialsDialog dlg = new CredentialsDialog (uri, items);
				try {
					result = MessageService.ShowCustomDialog (dlg) == (int)Gtk.ResponseType.Ok;
				} finally {
					dlg.Destroy ();
				}
			});
			
			if (username != null && password != null && result)
				PasswordService.AddWebPassword (new Uri (uri.ToString ()), new string (password.GetValue ()));

			return result;
		}
		
		bool TryGetFromPasswordService (URIish uri, CredentialItem.Username username, CredentialItem.Password password)
		{
			var actualUrl = new Uri (uri.ToString ());
			var passwordValue = PasswordService.GetWebPassword (actualUrl);
			if (passwordValue != null) {
				username.SetValue (actualUrl.UserInfo);
				password.SetValue (passwordValue.ToArray ());
				return true;
			}
			
			return false;
		}
	}
}

