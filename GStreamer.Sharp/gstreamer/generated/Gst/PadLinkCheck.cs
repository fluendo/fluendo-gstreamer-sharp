// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (Gst.PadLinkCheckGType))]
	public enum PadLinkCheck : uint {

		Nothing = 0,
		Hierarchy = 1,
		TemplateCaps = 2,
		Caps = 4,
		Default = 5,
		NoReconfigure = 8,
	}

	internal class PadLinkCheckGType {
		[DllImport ("gstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_pad_link_check_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gst_pad_link_check_get_type ());
			}
		}
	}
#endregion
}
