// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLibSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate IntPtr SettingsBindSetMappingNative(IntPtr value, IntPtr expected_type, IntPtr user_data);

	internal class SettingsBindSetMappingInvoker {

		SettingsBindSetMappingNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~SettingsBindSetMappingInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal SettingsBindSetMappingInvoker (SettingsBindSetMappingNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal SettingsBindSetMappingInvoker (SettingsBindSetMappingNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal SettingsBindSetMappingInvoker (SettingsBindSetMappingNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal GLib.SettingsBindSetMapping Handler {
			get {
				return new GLib.SettingsBindSetMapping(InvokeNative);
			}
		}

		GLib.Variant InvokeNative (GLib.Value value, GLib.VariantType expected_type)
		{
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			GLib.Variant __result = new GLib.Variant(native_cb (native_value, expected_type == null ? IntPtr.Zero : expected_type.Handle, __data));
			Marshal.FreeHGlobal (native_value);
			return __result;
		}
	}

	internal class SettingsBindSetMappingWrapper {

		public IntPtr NativeCallback (IntPtr value, IntPtr expected_type, IntPtr user_data)
		{
			try {
				GLib.Variant __ret = managed ((GLib.Value) Marshal.PtrToStructure (value, typeof (GLib.Value)), new GLib.VariantType(expected_type));
				if (release_on_call)
					gch.Free ();
				return __ret == null ? IntPtr.Zero : __ret.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal SettingsBindSetMappingNative NativeDelegate;
		GLib.SettingsBindSetMapping managed;

		public SettingsBindSetMappingWrapper (GLib.SettingsBindSetMapping managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new SettingsBindSetMappingNative (NativeCallback);
		}

		public static GLib.SettingsBindSetMapping GetManagedDelegate (SettingsBindSetMappingNative native)
		{
			if (native == null)
				return null;
			SettingsBindSetMappingWrapper wrapper = (SettingsBindSetMappingWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
