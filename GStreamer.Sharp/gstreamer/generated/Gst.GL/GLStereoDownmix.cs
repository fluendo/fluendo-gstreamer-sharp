// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GL {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gst.GL.GLStereoDownmixGType))]
	public enum GLStereoDownmix {

		GreenMagentaDubois = 0,
		RedCyanDubois = 1,
		AmberBlueDubois = 2,
	}

	internal class GLStereoDownmixGType {
		[DllImport ("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_stereo_downmix_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_gl_stereo_downmix_get_type ());
			}
		}
	}
#endregion
}
