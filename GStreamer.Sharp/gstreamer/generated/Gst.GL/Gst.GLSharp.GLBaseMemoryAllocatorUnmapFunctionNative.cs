// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GLSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void GLBaseMemoryAllocatorUnmapFunctionNative(IntPtr mem, IntPtr info);

	internal class GLBaseMemoryAllocatorUnmapFunctionInvoker {

		GLBaseMemoryAllocatorUnmapFunctionNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~GLBaseMemoryAllocatorUnmapFunctionInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal GLBaseMemoryAllocatorUnmapFunctionInvoker (GLBaseMemoryAllocatorUnmapFunctionNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal GLBaseMemoryAllocatorUnmapFunctionInvoker (GLBaseMemoryAllocatorUnmapFunctionNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal GLBaseMemoryAllocatorUnmapFunctionInvoker (GLBaseMemoryAllocatorUnmapFunctionNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.GL.GLBaseMemoryAllocatorUnmapFunction Handler {
			get {
				return new Gst.GL.GLBaseMemoryAllocatorUnmapFunction(InvokeNative);
			}
		}

		void InvokeNative (Gst.GL.GLBaseMemory mem, Gst.MapInfo info)
		{
			IntPtr native_mem = GLib.Marshaller.StructureToPtrAlloc (mem);
			IntPtr native_info = GLib.Marshaller.StructureToPtrAlloc (info);
			native_cb (native_mem, native_info);
			Marshal.FreeHGlobal (native_mem);
			Marshal.FreeHGlobal (native_info);
		}
	}

	internal class GLBaseMemoryAllocatorUnmapFunctionWrapper {

		public void NativeCallback (IntPtr mem, IntPtr info)
		{
			try {
				managed (Gst.GL.GLBaseMemory.New (mem), Gst.MapInfo.New (info));
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal GLBaseMemoryAllocatorUnmapFunctionNative NativeDelegate;
		Gst.GL.GLBaseMemoryAllocatorUnmapFunction managed;

		public GLBaseMemoryAllocatorUnmapFunctionWrapper (Gst.GL.GLBaseMemoryAllocatorUnmapFunction managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new GLBaseMemoryAllocatorUnmapFunctionNative (NativeCallback);
		}

		public static Gst.GL.GLBaseMemoryAllocatorUnmapFunction GetManagedDelegate (GLBaseMemoryAllocatorUnmapFunctionNative native)
		{
			if (native == null)
				return null;
			GLBaseMemoryAllocatorUnmapFunctionWrapper wrapper = (GLBaseMemoryAllocatorUnmapFunctionWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
