// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (GLib.ZlibCompressorFormatGType))]
	public enum ZlibCompressorFormat {

		Zlib,
		Gzip,
		Raw,
	}

	internal class ZlibCompressorFormatGType {
		[DllImport ("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_zlib_compressor_format_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_zlib_compressor_format_get_type ());
			}
		}
	}
#endregion
}
