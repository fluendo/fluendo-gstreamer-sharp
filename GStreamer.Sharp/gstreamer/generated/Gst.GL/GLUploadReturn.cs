// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GL {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.GL.GLUploadReturnGType))]
	public enum GLUploadReturn {

		UnsharedGlContext = -100,
		Reconfigure = -3,
		Unsupported = -2,
		Error = -1,
		Done = 1,
	}

	internal class GLUploadReturnGType {
		[DllImport ("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_upload_return_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_gl_upload_return_get_type ());
			}
		}
	}
#endregion
}
