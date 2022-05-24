// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GL {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class GLContext : Gst.Object {

		protected GLContext (IntPtr raw) : base(raw) {}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_context_new(IntPtr display);

		public GLContext (Gst.GL.GLDisplay display) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (GLContext)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gst_gl_context_new(display == null ? IntPtr.Zero : display.Handle);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_context_new_wrapped(IntPtr display, UIntPtr handle, int context_type, int available_apis);

		public GLContext (Gst.GL.GLDisplay display, ulong handle, Gst.GL.GLPlatform context_type, Gst.GL.GLAPI available_apis) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (GLContext)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gst_gl_context_new_wrapped(display == null ? IntPtr.Zero : display.Handle, new UIntPtr (handle), (int) context_type, (int) available_apis);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_context_get_display(IntPtr raw);

		public Gst.GL.GLDisplay Display {
			get  {
				IntPtr raw_ret = gst_gl_context_get_display(Handle);
				Gst.GL.GLDisplay ret = GLib.Object.GetObject(raw_ret, true) as Gst.GL.GLDisplay;
				return ret;
			}
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_context_get_window(IntPtr raw);

		public Gst.GL.GLWindow Window {
			get  {
				IntPtr raw_ret = gst_gl_context_get_window(Handle);
				Gst.GL.GLWindow ret = GLib.Object.GetObject(raw_ret, true) as Gst.GL.GLWindow;
				return ret;
			}
		}

		public Gst.GL.GLFuncs GlVtable {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("gl_vtable"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Gst.GL.GLFuncs) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Gst.GL.GLFuncs), false);
				}
			}
		}

		static GetGlContextNativeDelegate GetGlContext_cb_delegate;
		static GetGlContextNativeDelegate GetGlContextVMCallback {
			get {
				if (GetGlContext_cb_delegate == null)
					GetGlContext_cb_delegate = new GetGlContextNativeDelegate (GetGlContext_cb);
				return GetGlContext_cb_delegate;
			}
		}

		static void OverrideGetGlContext (GLib.GType gtype)
		{
			OverrideGetGlContext (gtype, GetGlContextVMCallback);
		}

		static void OverrideGetGlContext (GLib.GType gtype, GetGlContextNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_gl_context"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate UIntPtr GetGlContextNativeDelegate (IntPtr inst);

		static UIntPtr GetGlContext_cb (IntPtr inst)
		{
			try {
				GLContext __obj = GLib.Object.GetObject (inst, false) as GLContext;
				ulong __result;
				__result = __obj.OnGetGlContext ();
				return new UIntPtr (__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLContext), ConnectionMethod="OverrideGetGlContext")]
		protected virtual ulong OnGetGlContext ()
		{
			return InternalGetGlContext ();
		}

		private ulong InternalGetGlContext ()
		{
			GetGlContextNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_gl_context"));
				unmanaged = (GetGlContextNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetGlContextNativeDelegate));
			}
			if (unmanaged == null) return 0;

			UIntPtr __result = unmanaged (this.Handle);
			return (ulong) __result;
		}

		static GetGlApiNativeDelegate GetGlApi_cb_delegate;
		static GetGlApiNativeDelegate GetGlApiVMCallback {
			get {
				if (GetGlApi_cb_delegate == null)
					GetGlApi_cb_delegate = new GetGlApiNativeDelegate (GetGlApi_cb);
				return GetGlApi_cb_delegate;
			}
		}

		static void OverrideGetGlApi (GLib.GType gtype)
		{
			OverrideGetGlApi (gtype, GetGlApiVMCallback);
		}

		static void OverrideGetGlApi (GLib.GType gtype, GetGlApiNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_gl_api"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetGlApiNativeDelegate (IntPtr inst);

		static int GetGlApi_cb (IntPtr inst)
		{
			try {
				GLContext __obj = GLib.Object.GetObject (inst, false) as GLContext;
				Gst.GL.GLAPI __result;
				__result = __obj.OnGetGlApi ();
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLContext), ConnectionMethod="OverrideGetGlApi")]
		protected virtual Gst.GL.GLAPI OnGetGlApi ()
		{
			return InternalGetGlApi ();
		}

		private Gst.GL.GLAPI InternalGetGlApi ()
		{
			GetGlApiNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_gl_api"));
				unmanaged = (GetGlApiNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetGlApiNativeDelegate));
			}
			if (unmanaged == null) return (Gst.GL.GLAPI) 0;

			int __result = unmanaged (this.Handle);
			return (Gst.GL.GLAPI) __result;
		}

		static GetGlPlatformNativeDelegate GetGlPlatform_cb_delegate;
		static GetGlPlatformNativeDelegate GetGlPlatformVMCallback {
			get {
				if (GetGlPlatform_cb_delegate == null)
					GetGlPlatform_cb_delegate = new GetGlPlatformNativeDelegate (GetGlPlatform_cb);
				return GetGlPlatform_cb_delegate;
			}
		}

		static void OverrideGetGlPlatform (GLib.GType gtype)
		{
			OverrideGetGlPlatform (gtype, GetGlPlatformVMCallback);
		}

		static void OverrideGetGlPlatform (GLib.GType gtype, GetGlPlatformNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_gl_platform"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetGlPlatformNativeDelegate (IntPtr inst);

		static int GetGlPlatform_cb (IntPtr inst)
		{
			try {
				GLContext __obj = GLib.Object.GetObject (inst, false) as GLContext;
				Gst.GL.GLPlatform __result;
				__result = __obj.OnGetGlPlatform ();
				return (int) __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLContext), ConnectionMethod="OverrideGetGlPlatform")]
		protected virtual Gst.GL.GLPlatform OnGetGlPlatform ()
		{
			return InternalGetGlPlatform ();
		}

		private Gst.GL.GLPlatform InternalGetGlPlatform ()
		{
			GetGlPlatformNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_gl_platform"));
				unmanaged = (GetGlPlatformNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetGlPlatformNativeDelegate));
			}
			if (unmanaged == null) return (Gst.GL.GLPlatform) 0;

			int __result = unmanaged (this.Handle);
			return (Gst.GL.GLPlatform) __result;
		}

		static ActivateNativeDelegate Activate_cb_delegate;
		static ActivateNativeDelegate ActivateVMCallback {
			get {
				if (Activate_cb_delegate == null)
					Activate_cb_delegate = new ActivateNativeDelegate (Activate_cb);
				return Activate_cb_delegate;
			}
		}

		static void OverrideActivate (GLib.GType gtype)
		{
			OverrideActivate (gtype, ActivateVMCallback);
		}

		static void OverrideActivate (GLib.GType gtype, ActivateNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("activate"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool ActivateNativeDelegate (IntPtr inst, bool activate);

		static bool Activate_cb (IntPtr inst, bool activate)
		{
			try {
				GLContext __obj = GLib.Object.GetObject (inst, false) as GLContext;
				bool __result;
				__result = __obj.OnActivate (activate);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLContext), ConnectionMethod="OverrideActivate")]
		protected virtual bool OnActivate (bool activate)
		{
			return InternalActivate (activate);
		}

		private bool InternalActivate (bool activate)
		{
			ActivateNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("activate"));
				unmanaged = (ActivateNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ActivateNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, activate);
			return __result;
		}

		static ChooseFormatNativeDelegate ChooseFormat_cb_delegate;
		static ChooseFormatNativeDelegate ChooseFormatVMCallback {
			get {
				if (ChooseFormat_cb_delegate == null)
					ChooseFormat_cb_delegate = new ChooseFormatNativeDelegate (ChooseFormat_cb);
				return ChooseFormat_cb_delegate;
			}
		}

		static void OverrideChooseFormat (GLib.GType gtype)
		{
			OverrideChooseFormat (gtype, ChooseFormatVMCallback);
		}

		static void OverrideChooseFormat (GLib.GType gtype, ChooseFormatNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("choose_format"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool ChooseFormatNativeDelegate (IntPtr inst, out IntPtr error);

		static bool ChooseFormat_cb (IntPtr inst, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				GLContext __obj = GLib.Object.GetObject (inst, false) as GLContext;
				bool __result;
				__result = __obj.OnChooseFormat ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLContext), ConnectionMethod="OverrideChooseFormat")]
		protected virtual bool OnChooseFormat ()
		{
			return InternalChooseFormat ();
		}

		private bool InternalChooseFormat ()
		{
			ChooseFormatNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("choose_format"));
				unmanaged = (ChooseFormatNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ChooseFormatNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			bool __result = unmanaged (this.Handle, out error);
			return __result;
		}

		static CreateContextNativeDelegate CreateContext_cb_delegate;
		static CreateContextNativeDelegate CreateContextVMCallback {
			get {
				if (CreateContext_cb_delegate == null)
					CreateContext_cb_delegate = new CreateContextNativeDelegate (CreateContext_cb);
				return CreateContext_cb_delegate;
			}
		}

		static void OverrideCreateContext (GLib.GType gtype)
		{
			OverrideCreateContext (gtype, CreateContextVMCallback);
		}

		static void OverrideCreateContext (GLib.GType gtype, CreateContextNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("create_context"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool CreateContextNativeDelegate (IntPtr inst, int gl_api, IntPtr other_context, out IntPtr error);

		static bool CreateContext_cb (IntPtr inst, int gl_api, IntPtr other_context, out IntPtr error)
		{
			error = IntPtr.Zero;

			try {
				GLContext __obj = GLib.Object.GetObject (inst, false) as GLContext;
				bool __result;
				__result = __obj.OnCreateContext ((Gst.GL.GLAPI) gl_api, GLib.Object.GetObject(other_context) as Gst.GL.GLContext);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLContext), ConnectionMethod="OverrideCreateContext")]
		protected virtual bool OnCreateContext (Gst.GL.GLAPI gl_api, Gst.GL.GLContext other_context)
		{
			return InternalCreateContext (gl_api, other_context);
		}

		private bool InternalCreateContext (Gst.GL.GLAPI gl_api, Gst.GL.GLContext other_context)
		{
			CreateContextNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("create_context"));
				unmanaged = (CreateContextNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(CreateContextNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			IntPtr error = IntPtr.Zero;
			bool __result = unmanaged (this.Handle, (int) gl_api, other_context == null ? IntPtr.Zero : other_context.Handle, out error);
			return __result;
		}

		static DestroyContextNativeDelegate DestroyContext_cb_delegate;
		static DestroyContextNativeDelegate DestroyContextVMCallback {
			get {
				if (DestroyContext_cb_delegate == null)
					DestroyContext_cb_delegate = new DestroyContextNativeDelegate (DestroyContext_cb);
				return DestroyContext_cb_delegate;
			}
		}

		static void OverrideDestroyContext (GLib.GType gtype)
		{
			OverrideDestroyContext (gtype, DestroyContextVMCallback);
		}

		static void OverrideDestroyContext (GLib.GType gtype, DestroyContextNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("destroy_context"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DestroyContextNativeDelegate (IntPtr inst);

		static void DestroyContext_cb (IntPtr inst)
		{
			try {
				GLContext __obj = GLib.Object.GetObject (inst, false) as GLContext;
				__obj.OnDestroyContext ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLContext), ConnectionMethod="OverrideDestroyContext")]
		protected virtual void OnDestroyContext ()
		{
			InternalDestroyContext ();
		}

		private void InternalDestroyContext ()
		{
			DestroyContextNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("destroy_context"));
				unmanaged = (DestroyContextNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(DestroyContextNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static SwapBuffersNativeDelegate SwapBuffers_cb_delegate;
		static SwapBuffersNativeDelegate SwapBuffersVMCallback {
			get {
				if (SwapBuffers_cb_delegate == null)
					SwapBuffers_cb_delegate = new SwapBuffersNativeDelegate (SwapBuffers_cb);
				return SwapBuffers_cb_delegate;
			}
		}

		static void OverrideSwapBuffers (GLib.GType gtype)
		{
			OverrideSwapBuffers (gtype, SwapBuffersVMCallback);
		}

		static void OverrideSwapBuffers (GLib.GType gtype, SwapBuffersNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("swap_buffers"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SwapBuffersNativeDelegate (IntPtr inst);

		static void SwapBuffers_cb (IntPtr inst)
		{
			try {
				GLContext __obj = GLib.Object.GetObject (inst, false) as GLContext;
				__obj.OnSwapBuffers ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLContext), ConnectionMethod="OverrideSwapBuffers")]
		protected virtual void OnSwapBuffers ()
		{
			InternalSwapBuffers ();
		}

		private void InternalSwapBuffers ()
		{
			SwapBuffersNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("swap_buffers"));
				unmanaged = (SwapBuffersNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SwapBuffersNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static CheckFeatureNativeDelegate CheckFeature_cb_delegate;
		static CheckFeatureNativeDelegate CheckFeatureVMCallback {
			get {
				if (CheckFeature_cb_delegate == null)
					CheckFeature_cb_delegate = new CheckFeatureNativeDelegate (CheckFeature_cb);
				return CheckFeature_cb_delegate;
			}
		}

		static void OverrideCheckFeature (GLib.GType gtype)
		{
			OverrideCheckFeature (gtype, CheckFeatureVMCallback);
		}

		static void OverrideCheckFeature (GLib.GType gtype, CheckFeatureNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("check_feature"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool CheckFeatureNativeDelegate (IntPtr inst, IntPtr feature);

		static bool CheckFeature_cb (IntPtr inst, IntPtr feature)
		{
			try {
				GLContext __obj = GLib.Object.GetObject (inst, false) as GLContext;
				bool __result;
				__result = __obj.OnCheckFeature (GLib.Marshaller.Utf8PtrToString (feature));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLContext), ConnectionMethod="OverrideCheckFeature")]
		protected virtual bool OnCheckFeature (string feature)
		{
			return InternalCheckFeature (feature);
		}

		private bool InternalCheckFeature (string feature)
		{
			CheckFeatureNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("check_feature"));
				unmanaged = (CheckFeatureNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(CheckFeatureNativeDelegate));
			}
			if (unmanaged == null) return false;

			IntPtr native_feature = GLib.Marshaller.StringToPtrGStrdup (feature);
			bool __result = unmanaged (this.Handle, native_feature);
			GLib.Marshaller.Free (native_feature);
			return __result;
		}

		static GetGlPlatformVersionNativeDelegate GetGlPlatformVersion_cb_delegate;
		static GetGlPlatformVersionNativeDelegate GetGlPlatformVersionVMCallback {
			get {
				if (GetGlPlatformVersion_cb_delegate == null)
					GetGlPlatformVersion_cb_delegate = new GetGlPlatformVersionNativeDelegate (GetGlPlatformVersion_cb);
				return GetGlPlatformVersion_cb_delegate;
			}
		}

		static void OverrideGetGlPlatformVersion (GLib.GType gtype)
		{
			OverrideGetGlPlatformVersion (gtype, GetGlPlatformVersionVMCallback);
		}

		static void OverrideGetGlPlatformVersion (GLib.GType gtype, GetGlPlatformVersionNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_gl_platform_version"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetGlPlatformVersionNativeDelegate (IntPtr inst, out int major, out int minor);

		static void GetGlPlatformVersion_cb (IntPtr inst, out int major, out int minor)
		{
			try {
				GLContext __obj = GLib.Object.GetObject (inst, false) as GLContext;
				__obj.OnGetGlPlatformVersion (out major, out minor);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLContext), ConnectionMethod="OverrideGetGlPlatformVersion")]
		protected virtual void OnGetGlPlatformVersion (out int major, out int minor)
		{
			InternalGetGlPlatformVersion (out major, out minor);
		}

		private void InternalGetGlPlatformVersion (out int major, out int minor)
		{
			GetGlPlatformVersionNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_gl_platform_version"));
				unmanaged = (GetGlPlatformVersionNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetGlPlatformVersionNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			unmanaged (this.Handle, out major, out minor);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("get_current_context"
							, Gst.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_current_context
							, null
							, "get_gl_context"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_gl_context"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_gl_context
							, "get_current_context"
							, "get_gl_api"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_gl_api"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_gl_api
							, "get_gl_context"
							, "get_gl_platform"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_gl_platform"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_gl_platform
							, "get_gl_api"
							, "get_proc_address"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_proc_address"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_proc_address
							, "get_gl_platform"
							, "activate"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("activate"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // activate
							, "get_proc_address"
							, "choose_format"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("choose_format"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // choose_format
							, "activate"
							, "create_context"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("create_context"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // create_context
							, "choose_format"
							, "destroy_context"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("destroy_context"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // destroy_context
							, "create_context"
							, "swap_buffers"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("swap_buffers"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // swap_buffers
							, "destroy_context"
							, "check_feature"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("check_feature"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // check_feature
							, "swap_buffers"
							, "get_gl_platform_version"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_gl_platform_version"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_gl_platform_version
							, "check_feature"
							, "_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _reserved
							, "get_gl_platform_version"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_context_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_gl_context_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_context_default_get_proc_address(int gl_api, IntPtr name);

		public static IntPtr DefaultGetProcAddress(Gst.GL.GLAPI gl_api, string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_gl_context_default_get_proc_address((int) gl_api, native_name);
			IntPtr ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_context_get_current();

		public static Gst.GL.GLContext Current { 
			get {
				IntPtr raw_ret = gst_gl_context_get_current();
				Gst.GL.GLContext ret = GLib.Object.GetObject(raw_ret) as Gst.GL.GLContext;
				return ret;
			}
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_gl_context_get_current_gl_api(int platform, out uint major, out uint minor);

		public static Gst.GL.GLAPI GetCurrentGlApi(Gst.GL.GLPlatform platform, out uint major, out uint minor) {
			int raw_ret = gst_gl_context_get_current_gl_api((int) platform, out major, out minor);
			Gst.GL.GLAPI ret = (Gst.GL.GLAPI) raw_ret;
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gst_gl_context_get_current_gl_context(int context_type);

		public static ulong GetCurrentGlContext(Gst.GL.GLPlatform context_type) {
			UIntPtr raw_ret = gst_gl_context_get_current_gl_context((int) context_type);
			ulong ret = (ulong) raw_ret;
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_context_get_proc_address_with_platform(int context_type, int gl_api, IntPtr name);

		public static IntPtr GetProcAddressWithPlatform(Gst.GL.GLPlatform context_type, Gst.GL.GLAPI gl_api, string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_gl_context_get_proc_address_with_platform((int) context_type, (int) gl_api, native_name);
			IntPtr ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_gl_context_activate(IntPtr raw, bool activate);

		public bool Activate(bool activate) {
			bool raw_ret = gst_gl_context_activate(Handle, activate);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_gl_context_can_share(IntPtr raw, IntPtr other_context);

		public bool CanShare(Gst.GL.GLContext other_context) {
			bool raw_ret = gst_gl_context_can_share(Handle, other_context == null ? IntPtr.Zero : other_context.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_gl_context_check_feature(IntPtr raw, IntPtr feature);

		public bool CheckFeature(string feature) {
			IntPtr native_feature = GLib.Marshaller.StringToPtrGStrdup (feature);
			bool raw_ret = gst_gl_context_check_feature(Handle, native_feature);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_feature);
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_gl_context_check_framebuffer_status(IntPtr raw, uint fbo_target);

		public bool CheckFramebufferStatus(uint fbo_target) {
			bool raw_ret = gst_gl_context_check_framebuffer_status(Handle, fbo_target);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_gl_context_check_gl_version(IntPtr raw, int api, int maj, int min);

		public bool CheckGlVersion(Gst.GL.GLAPI api, int maj, int min) {
			bool raw_ret = gst_gl_context_check_gl_version(Handle, (int) api, maj, min);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_context_clear_framebuffer(IntPtr raw);

		public void ClearFramebuffer() {
			gst_gl_context_clear_framebuffer(Handle);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_context_clear_shader(IntPtr raw);

		public void ClearShader() {
			gst_gl_context_clear_shader(Handle);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gst_gl_context_create(IntPtr raw, IntPtr other_context, out IntPtr error);

		public unsafe bool Create(Gst.GL.GLContext other_context) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gst_gl_context_create(Handle, other_context == null ? IntPtr.Zero : other_context.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		public bool Create() {
			return Create (null);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_context_destroy(IntPtr raw);

		public void Destroy() {
			gst_gl_context_destroy(Handle);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gst_gl_context_fill_info(IntPtr raw, out IntPtr error);

		public unsafe bool FillInfo() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gst_gl_context_fill_info(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_gl_context_get_gl_api(IntPtr raw);

		public Gst.GL.GLAPI GlApi { 
			get {
				int raw_ret = gst_gl_context_get_gl_api(Handle);
				Gst.GL.GLAPI ret = (Gst.GL.GLAPI) raw_ret;
				return ret;
			}
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr gst_gl_context_get_gl_context(IntPtr raw);

		public ulong GlContext { 
			get {
				UIntPtr raw_ret = gst_gl_context_get_gl_context(Handle);
				ulong ret = (ulong) raw_ret;
				return ret;
			}
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_gl_context_get_gl_platform(IntPtr raw);

		public Gst.GL.GLPlatform GlPlatform { 
			get {
				int raw_ret = gst_gl_context_get_gl_platform(Handle);
				Gst.GL.GLPlatform ret = (Gst.GL.GLPlatform) raw_ret;
				return ret;
			}
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_context_get_gl_platform_version(IntPtr raw, out int major, out int minor);

		public void GetGlPlatformVersion(out int major, out int minor) {
			gst_gl_context_get_gl_platform_version(Handle, out major, out minor);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_context_get_gl_version(IntPtr raw, out int maj, out int min);

		public void GetGlVersion(out int maj, out int min) {
			gst_gl_context_get_gl_version(Handle, out maj, out min);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_context_get_proc_address(IntPtr raw, IntPtr name);

		public IntPtr GetProcAddress(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = gst_gl_context_get_proc_address(Handle, native_name);
			IntPtr ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern GLib.Thread gst_gl_context_get_thread(IntPtr raw);

		public GLib.Thread Thread { 
			get {
				GLib.Thread raw_ret = gst_gl_context_get_thread(Handle);
				GLib.Thread ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_gl_context_is_shared(IntPtr raw);

		public bool IsShared { 
			get {
				bool raw_ret = gst_gl_context_is_shared(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_context_set_shared_with(IntPtr raw, IntPtr share);

		public Gst.GL.GLContext SharedWith { 
			set {
				gst_gl_context_set_shared_with(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_gl_context_set_window(IntPtr raw, IntPtr window);

		public bool SetWindow(Gst.GL.GLWindow window) {
			bool raw_ret = gst_gl_context_set_window(Handle, window == null ? IntPtr.Zero : window.OwnedHandle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_gl_context_supports_glsl_profile_version(IntPtr raw, int version, int profile);

		public bool SupportsGlslProfileVersion(Gst.GL.GLSLVersion version, Gst.GL.GLSLProfile profile) {
			bool raw_ret = gst_gl_context_supports_glsl_profile_version(Handle, (int) version, (int) profile);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_gl_context_supports_precision(IntPtr raw, int version, int profile);

		public bool SupportsPrecision(Gst.GL.GLSLVersion version, Gst.GL.GLSLProfile profile) {
			bool raw_ret = gst_gl_context_supports_precision(Handle, (int) version, (int) profile);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_gl_context_supports_precision_highp(IntPtr raw, int version, int profile);

		public bool SupportsPrecisionHighp(Gst.GL.GLSLVersion version, Gst.GL.GLSLProfile profile) {
			bool raw_ret = gst_gl_context_supports_precision_highp(Handle, (int) version, (int) profile);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_context_swap_buffers(IntPtr raw);

		public void SwapBuffers() {
			gst_gl_context_swap_buffers(Handle);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_context_thread_add(IntPtr raw, Gst.GLSharp.GLContextThreadFuncNative func, IntPtr data);

		public void ThreadAdd(Gst.GL.GLContextThreadFunc func) {
			Gst.GLSharp.GLContextThreadFuncWrapper func_wrapper = new Gst.GLSharp.GLContextThreadFuncWrapper (func);
			gst_gl_context_thread_add(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
		}


		static GLContext ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("display"
							, Gst.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // display
							, null
							, "window"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("window"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // window
							, "display"
							, "gl_vtable"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("gl_vtable"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // gl_vtable
							, "window"
							, "priv"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("priv"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, "gl_vtable"
							, "_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _reserved
							, "priv"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
