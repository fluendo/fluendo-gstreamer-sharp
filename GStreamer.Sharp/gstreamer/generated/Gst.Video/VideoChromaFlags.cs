// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.Video.VideoChromaFlagsGType))]
	public enum VideoChromaFlags : uint {

		None = 0,
		Interlaced = 1,
	}

	internal class VideoChromaFlagsGType {
		[DllImport ("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_chroma_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_video_chroma_flags_get_type ());
			}
		}
	}
#endregion
}
