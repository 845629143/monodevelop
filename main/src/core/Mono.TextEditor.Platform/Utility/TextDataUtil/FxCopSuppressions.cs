#if CODE_ANALYSIS_BASELINE
using System.Diagnostics.CodeAnalysis;

[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.VisualStudio.Text.Utilities")]
[module: SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "Microsoft.VisualStudio.Text.Utilities.ProjectionSpanDiffer.#DecomposeSpans()")]
[module: SuppressMessage("Microsoft.MSInternal","CA908:AvoidTypesThatRequireJitCompilationInPrecompiledAssemblies", Scope="member", Target="Microsoft.VisualStudio.Text.Utilities.BufferTracker.#ReportLiveBuffers(System.IO.TextWriter)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.VisualStudio.Text.Utilities.ExtensionSelector.#SelectBestMatchByContentType`3(System.Collections.Generic.IList`1<System.Lazy`2<!!0,!!1>>,Microsoft.VisualStudio.Utilities.IContentType,System.Func`2<!!0,!!2>,Microsoft.VisualStudio.Utilities.IContentTypeRegistryService,System.Collections.Generic.IEnumerable`1<Microsoft.VisualStudio.Text.IExtensionErrorHandler>)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.VisualStudio.Text.Utilities.TextUtilities.#InstantiateExtension`2(System.Object,System.Lazy`2<!!0,!!1>,System.Collections.Generic.IEnumerable`1<Microsoft.VisualStudio.Text.IExtensionErrorHandler>)")]

[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.VisualStudio.Text.Utilities.GuardedOperations.#CallExtensionPoint(System.Object,System.Action)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.VisualStudio.Text.Utilities.GuardedOperations.#get_ErrorHandlers()")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.VisualStudio.Text.Utilities.GuardedOperations.#HandleException(System.Object,System.Exception)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.VisualStudio.Text.Utilities.GuardedOperations.#InstantiateExtension`2(System.Object,System.Lazy`2<!!0,!!1>)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.VisualStudio.Text.Utilities.GuardedOperations.#RaiseEvent(System.Object,System.EventHandler)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.VisualStudio.Text.Utilities.GuardedOperations.#RaiseEvent`1(System.Object,System.EventHandler`1<!!0>,!!0)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.VisualStudio.Text.Utilities.GuardedOperations.#InstantiateMatchingExtensions`3(System.Collections.Generic.IEnumerable`1<System.Lazy`2<!!1,!!2>>,System.Func`2<!!1,!!0>,Microsoft.VisualStudio.Utilities.IContentType,System.Object)")]

// todo: these should be deleted before checkin
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.VisualStudio.Text.Utilities.TextUtilities.#RaiseEvent(System.Object,System.EventHandler,System.Collections.Generic.IEnumerable`1<Microsoft.VisualStudio.Text.IExtensionErrorHandler>)", Justification = "We provide an extensible access point for detecting, logging, and presenting these exceptions.")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.VisualStudio.Text.Utilities.TextUtilities.#RaiseEvent`1(System.Object,System.EventHandler`1<!!0>,!!0,System.Collections.Generic.IEnumerable`1<Microsoft.VisualStudio.Text.IExtensionErrorHandler>)")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.VisualStudio.Text.Utilities.TextUtilities.#CallExtensionPoint(System.Object,System.Action,System.Collections.Generic.IEnumerable`1<Microsoft.VisualStudio.Text.IExtensionErrorHandler>)", Justification = "We provide an extensible access point for detecting, logging, and presenting these exceptions.")]
[module: SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.VisualStudio.Text.Utilities.TextUtilities.#HandleException(System.Object,System.Exception,System.Collections.Generic.IEnumerable`1<Microsoft.VisualStudio.Text.IExtensionErrorHandler>)", Justification = "We provide an extensible access point for detecting, logging, and presenting these exceptions.")]

// ToDo: To be looked at
[module: SuppressMessage("Microsoft.Reliability","CA2000:Dispose objects before losing scope", Scope="member", Target="Microsoft.VisualStudio.Text.Utilities.BufferTracker.#OnBufferCreated(System.Object,Microsoft.VisualStudio.Text.TextBufferCreatedEventArgs)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Design","CA1031:DoNotCatchGeneralExceptionTypes", Scope="member", Target="Microsoft.VisualStudio.Text.Utilities.GuardedOperations.#InstantiateExtension`1(System.Object,System.Lazy`1<!!0>)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Design","CA1031:DoNotCatchGeneralExceptionTypes", Scope="member", Target="Microsoft.VisualStudio.Text.Utilities.GuardedOperations.#InstantiateExtension`3(System.Object,System.Lazy`2<!!0,!!1>,System.Func`2<!!0,!!2>)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Design","CA1031:DoNotCatchGeneralExceptionTypes", Scope="member", Target="Microsoft.VisualStudio.Text.Utilities.GuardedOperations.#InvokeMatchingFactories`3(System.Collections.Generic.IEnumerable`1<System.Lazy`2<!!1,!!2>>,System.Func`2<!!1,!!0>,Microsoft.VisualStudio.Utilities.IContentType,System.Object)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Naming","CA2204:Literals should be spelled correctly", MessageId="IDataObject", Scope="member", Target="Microsoft.VisualStudio.Text.Data.Utilities.DataObjectManager.#ExtractHTMLText(System.Windows.IDataObject)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Naming","CA2204:Literals should be spelled correctly", MessageId="MemoryStream", Scope="member", Target="Microsoft.VisualStudio.Text.Data.Utilities.DataObjectManager.#ExtractHTMLText(System.Windows.IDataObject)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Globalization","CA1305:SpecifyIFormatProvider", MessageId="System.String.Format(System.String,System.Object)", Scope="member", Target="Microsoft.VisualStudio.Text.Utilities.MappingSpanSnapshot.#ToString()", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Performance","CA1811:AvoidUncalledPrivateCode", Scope="member", Target="Microsoft.VisualStudio.Text.Data.Utilities.DataObjectManager.#ContainsText(System.Windows.IDataObject)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Performance","CA1811:AvoidUncalledPrivateCode", Scope="member", Target="Microsoft.VisualStudio.Text.Utilities.GuardedOperations.#.ctor(Microsoft.VisualStudio.Text.IExtensionErrorHandler)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Performance","CA1811:AvoidUncalledPrivateCode", Scope="member", Target="Microsoft.VisualStudio.Text.Utilities.GuardedOperations.#set__errorHandlerExports(System.Collections.Generic.List`1<System.Lazy`1<Microsoft.VisualStudio.Text.IExtensionErrorHandler>>)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Performance","CA1811:AvoidUncalledPrivateCode", Scope="member", Target="Microsoft.VisualStudio.Text.Utilities.GuardedOperations.#set_ErrorHandlers(System.Collections.Generic.List`1<Microsoft.VisualStudio.Text.IExtensionErrorHandler>)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Performance","CA1811:AvoidUncalledPrivateCode", Scope="member", Target="Microsoft.VisualStudio.Text.Utilities.NativeMethods.#ClientToScreen(System.IntPtr,Microsoft.VisualStudio.Text.Utilities.NativeMethods+POINT&)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Performance","CA1811:AvoidUncalledPrivateCode", Scope="member", Target="Microsoft.VisualStudio.Text.Utilities.NativeMethods.#MonitorFromWindow(System.IntPtr,System.Int32)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Performance","CA1811:AvoidUncalledPrivateCode", Scope="member", Target="Microsoft.VisualStudio.Text.Utilities.TextUtilities.#CallExtensionPoint(System.Object,System.Action,System.Collections.Generic.IEnumerable`1<Microsoft.VisualStudio.Text.IExtensionErrorHandler>)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Performance","CA1811:AvoidUncalledPrivateCode", Scope="member", Target="Microsoft.VisualStudio.Text.Utilities.TextUtilities.#HandleException(System.Object,System.Exception,System.Collections.Generic.IEnumerable`1<Microsoft.VisualStudio.Text.IExtensionErrorHandler>)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Performance","CA1811:AvoidUncalledPrivateCode", Scope="member", Target="Microsoft.VisualStudio.Text.Utilities.TextUtilities.#RaiseEvent(System.Object,System.EventHandler,System.Collections.Generic.IEnumerable`1<Microsoft.VisualStudio.Text.IExtensionErrorHandler>)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Performance","CA1811:AvoidUncalledPrivateCode", Scope="member", Target="Microsoft.VisualStudio.Text.Utilities.TextUtilities.#RaiseEvent`1(System.Object,System.EventHandler`1<!!0>,!!0,System.Collections.Generic.IEnumerable`1<Microsoft.VisualStudio.Text.IExtensionErrorHandler>)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Performance","CA1811:AvoidUncalledPrivateCode", Scope="member", Target="Microsoft.VisualStudio.Text.Utilities.TextUtilities.#ScanForLineCount(System.Char[],System.Int32)", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Performance","CA1812:AvoidUninstantiatedInternalClasses", Scope="type", Target="Microsoft.VisualStudio.Text.Utilities.BufferTracker", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Performance","CA1812:AvoidUninstantiatedInternalClasses", Scope="type", Target="Microsoft.VisualStudio.Text.Utilities.EditorTracker", Justification="ToDo: To be looked at")]
[module: SuppressMessage("Microsoft.Performance","CA1812:AvoidUninstantiatedInternalClasses", Scope="type", Target="Microsoft.VisualStudio.Text.Utilities.TextViewMarginState", Justification="ToDo: To be looked at")]

#endif