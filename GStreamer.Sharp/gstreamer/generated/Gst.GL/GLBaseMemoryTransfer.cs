// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GL {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.GL.GLBaseMemoryTransferGType))]
	public enum GLBaseMemoryTransfer : uint {

		Download = 1048576,
		Upload = 2097152,
	}

	internal class GLBaseMemoryTransferGType {
		[DllImport ("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_base_memory_transfer_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_gl_base_memory_transfer_get_type ());
			}
		}
	}
#endregion
}
