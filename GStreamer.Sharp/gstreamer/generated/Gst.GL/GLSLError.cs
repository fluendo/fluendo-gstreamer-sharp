// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GL {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.GL.GLSLErrorGType))]
	public enum GLSLError {

		Compile = 0,
		Link = 1,
		Program = 2,
	}

	internal class GLSLErrorGType {
		[DllImport ("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_glsl_error_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_glsl_error_get_type ());
			}
		}
	}
#endregion
}
