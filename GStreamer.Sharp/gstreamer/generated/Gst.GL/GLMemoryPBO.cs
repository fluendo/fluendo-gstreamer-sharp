// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GL {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct GLMemoryPBO : IEquatable<GLMemoryPBO> {

		private Gst.GL.GLMemory mem;
		private IntPtr _pbo;

		[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
		private IntPtr[] _Padding;

		public static Gst.GL.GLMemoryPBO Zero = new Gst.GL.GLMemoryPBO ();

		public static Gst.GL.GLMemoryPBO New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.GL.GLMemoryPBO.Zero;
			return (Gst.GL.GLMemoryPBO) Marshal.PtrToStructure (raw, typeof (Gst.GL.GLMemoryPBO));
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_gl_memory_pbo_copy_into_texture(IntPtr raw, uint tex_id, int target, int tex_format, int width, int height, int stride, bool respecify);

		public bool CopyIntoTexture(uint tex_id, Gst.GL.GLTextureTarget target, Gst.GL.GLFormat tex_format, int width, int height, int stride, bool respecify) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			bool raw_ret = gst_gl_memory_pbo_copy_into_texture(this_as_native, tex_id, (int) target, (int) tex_format, width, height, stride, respecify);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_memory_pbo_download_transfer(IntPtr raw);

		public void DownloadTransfer() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gst_gl_memory_pbo_download_transfer(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_memory_pbo_upload_transfer(IntPtr raw);

		public void UploadTransfer() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gst_gl_memory_pbo_upload_transfer(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_memory_pbo_init_once();

		public static void InitOnce() {
			gst_gl_memory_pbo_init_once();
		}

		static void ReadNative (IntPtr native, ref Gst.GL.GLMemoryPBO target)
		{
			target = New (native);
		}

		public bool Equals (GLMemoryPBO other)
		{
			return true && mem.Equals (other.mem) && _pbo.Equals (other._pbo);
		}

		public override bool Equals (object other)
		{
			return other is GLMemoryPBO && Equals ((GLMemoryPBO) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ mem.GetHashCode () ^ _pbo.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
