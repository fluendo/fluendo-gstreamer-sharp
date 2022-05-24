// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GLSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate IntPtr GLBaseMemoryAllocatorMapFunctionNative(IntPtr mem, IntPtr info, UIntPtr maxsize);

	internal class GLBaseMemoryAllocatorMapFunctionInvoker {

		GLBaseMemoryAllocatorMapFunctionNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~GLBaseMemoryAllocatorMapFunctionInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal GLBaseMemoryAllocatorMapFunctionInvoker (GLBaseMemoryAllocatorMapFunctionNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal GLBaseMemoryAllocatorMapFunctionInvoker (GLBaseMemoryAllocatorMapFunctionNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal GLBaseMemoryAllocatorMapFunctionInvoker (GLBaseMemoryAllocatorMapFunctionNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.GL.GLBaseMemoryAllocatorMapFunction Handler {
			get {
				return new Gst.GL.GLBaseMemoryAllocatorMapFunction(InvokeNative);
			}
		}

		IntPtr InvokeNative (Gst.GL.GLBaseMemory mem, Gst.MapInfo info, ulong maxsize)
		{
			IntPtr native_mem = GLib.Marshaller.StructureToPtrAlloc (mem);
			IntPtr native_info = GLib.Marshaller.StructureToPtrAlloc (info);
			IntPtr __result = native_cb (native_mem, native_info, new UIntPtr (maxsize));
			Marshal.FreeHGlobal (native_mem);
			Marshal.FreeHGlobal (native_info);
			return __result;
		}
	}

	internal class GLBaseMemoryAllocatorMapFunctionWrapper {

		public IntPtr NativeCallback (IntPtr mem, IntPtr info, UIntPtr maxsize)
		{
			try {
				IntPtr __ret = managed (Gst.GL.GLBaseMemory.New (mem), Gst.MapInfo.New (info), (ulong) maxsize);
				if (release_on_call)
					gch.Free ();
				return __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal GLBaseMemoryAllocatorMapFunctionNative NativeDelegate;
		Gst.GL.GLBaseMemoryAllocatorMapFunction managed;

		public GLBaseMemoryAllocatorMapFunctionWrapper (Gst.GL.GLBaseMemoryAllocatorMapFunction managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new GLBaseMemoryAllocatorMapFunctionNative (NativeCallback);
		}

		public static Gst.GL.GLBaseMemoryAllocatorMapFunction GetManagedDelegate (GLBaseMemoryAllocatorMapFunctionNative native)
		{
			if (native == null)
				return null;
			GLBaseMemoryAllocatorMapFunctionWrapper wrapper = (GLBaseMemoryAllocatorMapFunctionWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
