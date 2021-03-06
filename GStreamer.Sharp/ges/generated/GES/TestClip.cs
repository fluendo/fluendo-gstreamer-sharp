// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TestClip : GES.SourceClip {

		public TestClip (IntPtr raw) : base(raw) {}

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_test_clip_new();

		public TestClip () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (TestClip)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = ges_test_clip_new();
		}

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_test_clip_new_for_nick(IntPtr nick);

		public TestClip (string nick) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (TestClip)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_nick = GLib.Marshaller.StringToPtrGStrdup (nick);
			Raw = ges_test_clip_new_for_nick(native_nick);
			GLib.Marshaller.Free (native_nick);
		}

		[GLib.Property ("freq")]
		public double Freq {
			get {
				GLib.Value val = GetProperty ("freq");
				double ret = (double) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("freq", val);
				val.Dispose ();
			}
		}

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_test_clip_set_mute(IntPtr raw, bool mute);

		[GLib.Property ("mute")]
		public bool Mute {
			get {
				GLib.Value val = GetProperty ("mute");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set  {
				ges_test_clip_set_mute(Handle, value);
			}
		}

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double ges_test_clip_get_volume(IntPtr raw);

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_test_clip_set_volume(IntPtr raw, double volume);

		[GLib.Property ("volume")]
		public double Volume {
			get  {
				double raw_ret = ges_test_clip_get_volume(Handle);
				double ret = raw_ret;
				return ret;
			}
			set  {
				ges_test_clip_set_volume(Handle, value);
			}
		}

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int ges_test_clip_get_vpattern(IntPtr raw);

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_test_clip_set_vpattern(IntPtr raw, int vpattern);

		[GLib.Property ("vpattern")]
		public GES.VideoTestPattern Vpattern {
			get  {
				int raw_ret = ges_test_clip_get_vpattern(Handle);
				GES.VideoTestPattern ret = (GES.VideoTestPattern) raw_ret;
				return ret;
			}
			set  {
				ges_test_clip_set_vpattern(Handle, (int) value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_ges_reserved"
							, GES.SourceClip.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _ges_reserved
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr ges_test_clip_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = ges_test_clip_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double ges_test_clip_get_frequency(IntPtr raw);

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void ges_test_clip_set_frequency(IntPtr raw, double freq);

		public double Frequency { 
			get {
				double raw_ret = ges_test_clip_get_frequency(Handle);
				double ret = raw_ret;
				return ret;
			}
			set {
				ges_test_clip_set_frequency(Handle, value);
			}
		}

		[DllImport("ges-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool ges_test_clip_is_muted(IntPtr raw);

		public bool IsMuted { 
			get {
				bool raw_ret = ges_test_clip_is_muted(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}


		static TestClip ()
		{
			GtkSharp.GstEditingServices.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GES.SourceClip.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, "_ges_reserved"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_ges_reserved"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _ges_reserved
							, "priv"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
