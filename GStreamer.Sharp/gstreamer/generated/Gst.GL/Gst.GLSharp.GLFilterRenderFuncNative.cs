// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GLSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool GLFilterRenderFuncNative(IntPtr filter, IntPtr in_tex, IntPtr user_data);

	internal class GLFilterRenderFuncInvoker {

		GLFilterRenderFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~GLFilterRenderFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal GLFilterRenderFuncInvoker (GLFilterRenderFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal GLFilterRenderFuncInvoker (GLFilterRenderFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal GLFilterRenderFuncInvoker (GLFilterRenderFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.GL.GLFilterRenderFunc Handler {
			get {
				return new Gst.GL.GLFilterRenderFunc(InvokeNative);
			}
		}

		bool InvokeNative (Gst.GL.GLFilter filter, Gst.GL.GLMemory in_tex)
		{
			IntPtr native_in_tex = GLib.Marshaller.StructureToPtrAlloc (in_tex);
			bool __result = native_cb (filter == null ? IntPtr.Zero : filter.Handle, native_in_tex, __data);
			Marshal.FreeHGlobal (native_in_tex);
			return __result;
		}
	}

	internal class GLFilterRenderFuncWrapper {

		public bool NativeCallback (IntPtr filter, IntPtr in_tex, IntPtr user_data)
		{
			try {
				bool __ret = managed (GLib.Object.GetObject(filter) as Gst.GL.GLFilter, Gst.GL.GLMemory.New (in_tex));
				if (release_on_call)
					gch.Free ();
				return __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
				return false;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal GLFilterRenderFuncNative NativeDelegate;
		Gst.GL.GLFilterRenderFunc managed;

		public GLFilterRenderFuncWrapper (Gst.GL.GLFilterRenderFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new GLFilterRenderFuncNative (NativeCallback);
		}

		public static Gst.GL.GLFilterRenderFunc GetManagedDelegate (GLFilterRenderFuncNative native)
		{
			if (native == null)
				return null;
			GLFilterRenderFuncWrapper wrapper = (GLFilterRenderFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
