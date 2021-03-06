// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GLSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate IntPtr GLBaseMemoryAllocatorAllocFunctionNative(IntPtr allocator, IntPtr parms);

	internal class GLBaseMemoryAllocatorAllocFunctionInvoker {

		GLBaseMemoryAllocatorAllocFunctionNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~GLBaseMemoryAllocatorAllocFunctionInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal GLBaseMemoryAllocatorAllocFunctionInvoker (GLBaseMemoryAllocatorAllocFunctionNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal GLBaseMemoryAllocatorAllocFunctionInvoker (GLBaseMemoryAllocatorAllocFunctionNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal GLBaseMemoryAllocatorAllocFunctionInvoker (GLBaseMemoryAllocatorAllocFunctionNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.GL.GLBaseMemoryAllocatorAllocFunction Handler {
			get {
				return new Gst.GL.GLBaseMemoryAllocatorAllocFunction(InvokeNative);
			}
		}

		Gst.GL.GLBaseMemory InvokeNative (Gst.GL.GLBaseMemoryAllocator allocator, Gst.GL.GLAllocationParams parms)
		{
			IntPtr native_parms = GLib.Marshaller.StructureToPtrAlloc (parms);
			Gst.GL.GLBaseMemory __result = Gst.GL.GLBaseMemory.New (native_cb (allocator == null ? IntPtr.Zero : allocator.Handle, native_parms));
			Marshal.FreeHGlobal (native_parms);
			return __result;
		}
	}

	internal class GLBaseMemoryAllocatorAllocFunctionWrapper {

		public IntPtr NativeCallback (IntPtr allocator, IntPtr parms)
		{
			try {
				Gst.GL.GLBaseMemory __ret = managed (GLib.Object.GetObject(allocator) as Gst.GL.GLBaseMemoryAllocator, Gst.GL.GLAllocationParams.New (parms));
				if (release_on_call)
					gch.Free ();
				return GLib.Marshaller.StructureToPtrAlloc (__ret);
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

		internal GLBaseMemoryAllocatorAllocFunctionNative NativeDelegate;
		Gst.GL.GLBaseMemoryAllocatorAllocFunction managed;

		public GLBaseMemoryAllocatorAllocFunctionWrapper (Gst.GL.GLBaseMemoryAllocatorAllocFunction managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new GLBaseMemoryAllocatorAllocFunctionNative (NativeCallback);
		}

		public static Gst.GL.GLBaseMemoryAllocatorAllocFunction GetManagedDelegate (GLBaseMemoryAllocatorAllocFunctionNative native)
		{
			if (native == null)
				return null;
			GLBaseMemoryAllocatorAllocFunctionWrapper wrapper = (GLBaseMemoryAllocatorAllocFunctionWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
