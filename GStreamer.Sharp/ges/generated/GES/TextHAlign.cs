// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (GES.TextHAlignGType))]
	public enum TextHAlign {

		Left = 0,
		Center = 1,
		Right = 2,
		Position = 4,
		Absolute = 5,
	}

	internal class TextHAlignGType {
		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_text_halign_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (ges_text_halign_get_type ());
			}
		}
	}
#endregion
}
