// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GL {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.GL.GLSLProfileGType))]
	public enum GLSLProfile : uint {

		None = 0,
		Es = 1,
		Core = 2,
		Compatibility = 4,
		Any = 4294967295,
	}

	internal class GLSLProfileGType {
		[DllImport ("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_glsl_profile_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_glsl_profile_get_type ());
			}
		}
	}
#endregion
}
