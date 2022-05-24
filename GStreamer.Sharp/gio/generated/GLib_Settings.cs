// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Settings : GLib.Object {

		public Settings (IntPtr raw) : base(raw) {}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_new(IntPtr schema_id);

		public Settings (string schema_id) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Settings)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("schema_id");
				vals.Add (new GLib.Value (schema_id));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_schema_id = GLib.Marshaller.StringToPtrGStrdup (schema_id);
			Raw = g_settings_new(native_schema_id);
			GLib.Marshaller.Free (native_schema_id);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_new_with_backend(IntPtr schema_id, IntPtr backend);

		public Settings (string schema_id, GLib.SettingsBackend backend) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Settings)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("schema_id");
				vals.Add (new GLib.Value (schema_id));
				if (backend != null) {
					names.Add ("backend");
					vals.Add (new GLib.Value (backend));
				}
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_schema_id = GLib.Marshaller.StringToPtrGStrdup (schema_id);
			Raw = g_settings_new_with_backend(native_schema_id, backend == null ? IntPtr.Zero : backend.Handle);
			GLib.Marshaller.Free (native_schema_id);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_new_with_backend_and_path(IntPtr schema_id, IntPtr backend, IntPtr path);

		public Settings (string schema_id, GLib.SettingsBackend backend, string path) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Settings)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("schema_id");
				vals.Add (new GLib.Value (schema_id));
				if (backend != null) {
					names.Add ("backend");
					vals.Add (new GLib.Value (backend));
				}
				names.Add ("path");
				vals.Add (new GLib.Value (path));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_schema_id = GLib.Marshaller.StringToPtrGStrdup (schema_id);
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			Raw = g_settings_new_with_backend_and_path(native_schema_id, backend == null ? IntPtr.Zero : backend.Handle, native_path);
			GLib.Marshaller.Free (native_schema_id);
			GLib.Marshaller.Free (native_path);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_new_with_path(IntPtr schema_id, IntPtr path);

		public Settings (string schema_id, string path) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Settings)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("schema_id");
				vals.Add (new GLib.Value (schema_id));
				names.Add ("path");
				vals.Add (new GLib.Value (path));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_schema_id = GLib.Marshaller.StringToPtrGStrdup (schema_id);
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			Raw = g_settings_new_with_path(native_schema_id, native_path);
			GLib.Marshaller.Free (native_schema_id);
			GLib.Marshaller.Free (native_path);
		}

		[GLib.Property ("backend")]
		public GLib.SettingsBackend Backend {
			get {
				GLib.Value val = GetProperty ("backend");
				GLib.SettingsBackend ret = (GLib.SettingsBackend) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("schema")]
		public string Schema {
			get {
				GLib.Value val = GetProperty ("schema");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("schema-id")]
		public string SchemaId {
			get {
				GLib.Value val = GetProperty ("schema-id");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("path")]
		public string Path {
			get {
				GLib.Value val = GetProperty ("path");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_get_has_unapplied(IntPtr raw);

		[GLib.Property ("has-unapplied")]
		public bool HasUnapplied {
			get  {
				bool raw_ret = g_settings_get_has_unapplied(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[GLib.Property ("delay-apply")]
		public bool DelayApply {
			get {
				GLib.Value val = GetProperty ("delay-apply");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Signal("writable-changed")]
		public event GLib.WritableChangedHandler WritableChanged {
			add {
				this.AddSignalHandler ("writable-changed", value, typeof (GLib.WritableChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("writable-changed", value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool ChangeEventSignalDelegate (IntPtr inst, out int arg0, int arg1, IntPtr gch);

		static bool ChangeEventSignalCallback (IntPtr inst, out int arg0, int arg1, IntPtr gch)
		{
			GLib.ChangeEventArgs args = new GLib.ChangeEventArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[2];
				args.Args[1] = arg1;
				GLib.ChangeEventHandler handler = (GLib.ChangeEventHandler) sig.Handler;
				handler (GLib.Object.GetObject (inst), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			try {
				arg0 = ((int)args.Args[0]);
				if (args.RetVal == null)
					return false;
				return ((bool) args.RetVal);
			} catch (Exception) {
				Exception ex = new Exception ("args.RetVal or 'out' property unset or set to incorrect type in GLib.ChangeEventHandler callback");
				GLib.ExceptionManager.RaiseUnhandledException (ex, true);
				// NOTREACHED: above call doesn't return.
				throw ex;
			}
		}

		[GLib.Signal("change-event")]
		public event GLib.ChangeEventHandler ChangeEvent {
			add {
				this.AddSignalHandler ("change-event", value, new ChangeEventSignalDelegate(ChangeEventSignalCallback));
			}
			remove {
				this.RemoveSignalHandler ("change-event", value);
			}
		}

		[GLib.Signal("writable-change-event")]
		public event GLib.WritableChangeEventHandler WritableChangeEvent {
			add {
				this.AddSignalHandler ("writable-change-event", value, typeof (GLib.WritableChangeEventArgs));
			}
			remove {
				this.RemoveSignalHandler ("writable-change-event", value);
			}
		}

		[GLib.Signal("changed")]
		public event GLib.ChangedHandler Changed {
			add {
				this.AddSignalHandler ("changed", value, typeof (GLib.ChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("changed", value);
			}
		}

		static WritableChangedNativeDelegate WritableChanged_cb_delegate;
		static WritableChangedNativeDelegate WritableChangedVMCallback {
			get {
				if (WritableChanged_cb_delegate == null)
					WritableChanged_cb_delegate = new WritableChangedNativeDelegate (WritableChanged_cb);
				return WritableChanged_cb_delegate;
			}
		}

		static void OverrideWritableChanged (GLib.GType gtype)
		{
			OverrideWritableChanged (gtype, WritableChangedVMCallback);
		}

		static void OverrideWritableChanged (GLib.GType gtype, WritableChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("writable_changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void WritableChangedNativeDelegate (IntPtr inst, IntPtr key);

		static void WritableChanged_cb (IntPtr inst, IntPtr key)
		{
			try {
				Settings __obj = GLib.Object.GetObject (inst, false) as Settings;
				__obj.OnWritableChanged (GLib.Marshaller.Utf8PtrToString (key));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.Settings), ConnectionMethod="OverrideWritableChanged")]
		protected virtual void OnWritableChanged (string key)
		{
			InternalWritableChanged (key);
		}

		private void InternalWritableChanged (string key)
		{
			WritableChangedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("writable_changed"));
				unmanaged = (WritableChangedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(WritableChangedNativeDelegate));
			}
			if (unmanaged == null) return;

			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			unmanaged (this.Handle, native_key);
			GLib.Marshaller.Free (native_key);
		}

		static ChangedNativeDelegate Changed_cb_delegate;
		static ChangedNativeDelegate ChangedVMCallback {
			get {
				if (Changed_cb_delegate == null)
					Changed_cb_delegate = new ChangedNativeDelegate (Changed_cb);
				return Changed_cb_delegate;
			}
		}

		static void OverrideChanged (GLib.GType gtype)
		{
			OverrideChanged (gtype, ChangedVMCallback);
		}

		static void OverrideChanged (GLib.GType gtype, ChangedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("changed"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangedNativeDelegate (IntPtr inst, IntPtr key);

		static void Changed_cb (IntPtr inst, IntPtr key)
		{
			try {
				Settings __obj = GLib.Object.GetObject (inst, false) as Settings;
				__obj.OnChanged (GLib.Marshaller.Utf8PtrToString (key));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.Settings), ConnectionMethod="OverrideChanged")]
		protected virtual void OnChanged (string key)
		{
			InternalChanged (key);
		}

		private void InternalChanged (string key)
		{
			ChangedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("changed"));
				unmanaged = (ChangedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ChangedNativeDelegate));
			}
			if (unmanaged == null) return;

			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			unmanaged (this.Handle, native_key);
			GLib.Marshaller.Free (native_key);
		}

		static WritableChangeEventNativeDelegate WritableChangeEvent_cb_delegate;
		static WritableChangeEventNativeDelegate WritableChangeEventVMCallback {
			get {
				if (WritableChangeEvent_cb_delegate == null)
					WritableChangeEvent_cb_delegate = new WritableChangeEventNativeDelegate (WritableChangeEvent_cb);
				return WritableChangeEvent_cb_delegate;
			}
		}

		static void OverrideWritableChangeEvent (GLib.GType gtype)
		{
			OverrideWritableChangeEvent (gtype, WritableChangeEventVMCallback);
		}

		static void OverrideWritableChangeEvent (GLib.GType gtype, WritableChangeEventNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("writable_change_event"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool WritableChangeEventNativeDelegate (IntPtr inst, int key);

		static bool WritableChangeEvent_cb (IntPtr inst, int key)
		{
			try {
				Settings __obj = GLib.Object.GetObject (inst, false) as Settings;
				bool __result;
				__result = __obj.OnWritableChangeEvent (key);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.Settings), ConnectionMethod="OverrideWritableChangeEvent")]
		protected virtual bool OnWritableChangeEvent (int key)
		{
			return InternalWritableChangeEvent (key);
		}

		private bool InternalWritableChangeEvent (int key)
		{
			WritableChangeEventNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("writable_change_event"));
				unmanaged = (WritableChangeEventNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(WritableChangeEventNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, key);
			return __result;
		}

		static ChangeEventNativeDelegate ChangeEvent_cb_delegate;
		static ChangeEventNativeDelegate ChangeEventVMCallback {
			get {
				if (ChangeEvent_cb_delegate == null)
					ChangeEvent_cb_delegate = new ChangeEventNativeDelegate (ChangeEvent_cb);
				return ChangeEvent_cb_delegate;
			}
		}

		static void OverrideChangeEvent (GLib.GType gtype)
		{
			OverrideChangeEvent (gtype, ChangeEventVMCallback);
		}

		static void OverrideChangeEvent (GLib.GType gtype, ChangeEventNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("change_event"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool ChangeEventNativeDelegate (IntPtr inst, out int keys, int n_keys);

		static bool ChangeEvent_cb (IntPtr inst, out int keys, int n_keys)
		{
			try {
				Settings __obj = GLib.Object.GetObject (inst, false) as Settings;
				bool __result;
				__result = __obj.OnChangeEvent (out keys, n_keys);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.Settings), ConnectionMethod="OverrideChangeEvent")]
		protected virtual bool OnChangeEvent (out int keys, int n_keys)
		{
			return InternalChangeEvent (out keys, n_keys);
		}

		private bool InternalChangeEvent (out int keys, int n_keys)
		{
			ChangeEventNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("change_event"));
				unmanaged = (ChangeEventNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ChangeEventNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			bool __result = unmanaged (this.Handle, out keys, n_keys);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("writable_changed"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // writable_changed
							, null
							, "changed"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("changed"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // changed
							, "writable_changed"
							, "writable_change_event"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("writable_change_event"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // writable_change_event
							, "changed"
							, "change_event"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("change_event"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // change_event
							, "writable_change_event"
							, "padding"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("padding"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 20 // padding
							, "change_event"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_settings_apply(IntPtr raw);

		public void Apply() {
			g_settings_apply(Handle);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_settings_bind(IntPtr raw, IntPtr key, IntPtr objekt, IntPtr property, int flags);

		public void Bind(string key, IntPtr objekt, string property, GLib.SettingsBindFlags flags) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr native_property = GLib.Marshaller.StringToPtrGStrdup (property);
			g_settings_bind(Handle, native_key, objekt, native_property, (int) flags);
			GLib.Marshaller.Free (native_key);
			GLib.Marshaller.Free (native_property);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_settings_bind_with_mapping(IntPtr raw, IntPtr key, IntPtr objekt, IntPtr property, int flags, GLibSharp.SettingsBindGetMappingNative get_mapping, GLibSharp.SettingsBindSetMappingNative set_mapping, IntPtr user_data, GLib.DestroyNotify destroy);

		public void BindWithMapping(string key, IntPtr objekt, string property, GLib.SettingsBindFlags flags, GLib.SettingsBindGetMapping get_mapping, GLib.SettingsBindSetMapping set_mapping) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr native_property = GLib.Marshaller.StringToPtrGStrdup (property);
			GLibSharp.SettingsBindGetMappingWrapper get_mapping_wrapper = new GLibSharp.SettingsBindGetMappingWrapper (get_mapping);
			GLibSharp.SettingsBindSetMappingWrapper set_mapping_wrapper = new GLibSharp.SettingsBindSetMappingWrapper (set_mapping);
			IntPtr user_data;
			GLib.DestroyNotify destroy;
			if (set_mapping == null) {
				user_data = IntPtr.Zero;
				destroy = null;
			} else {
				user_data = (IntPtr) GCHandle.Alloc (set_mapping_wrapper);
				destroy = GLib.DestroyHelper.NotifyHandler;
			}
			g_settings_bind_with_mapping(Handle, native_key, objekt, native_property, (int) flags, get_mapping_wrapper.NativeDelegate, set_mapping_wrapper.NativeDelegate, user_data, destroy);
			GLib.Marshaller.Free (native_key);
			GLib.Marshaller.Free (native_property);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_settings_bind_writable(IntPtr raw, IntPtr key, IntPtr objekt, IntPtr property, bool inverted);

		public void BindWritable(string key, IntPtr objekt, string property, bool inverted) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr native_property = GLib.Marshaller.StringToPtrGStrdup (property);
			g_settings_bind_writable(Handle, native_key, objekt, native_property, inverted);
			GLib.Marshaller.Free (native_key);
			GLib.Marshaller.Free (native_property);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_create_action(IntPtr raw, IntPtr key);

		public GLib.IAction CreateAction(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr raw_ret = g_settings_create_action(Handle, native_key);
			GLib.IAction ret = GLib.ActionAdapter.GetObject (raw_ret, false);
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_settings_delay(IntPtr raw);

		public void Delay() {
			g_settings_delay(Handle);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_get_boolean(IntPtr raw, IntPtr key);

		public bool GetBoolean(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			bool raw_ret = g_settings_get_boolean(Handle, native_key);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_get_child(IntPtr raw, IntPtr name);

		public GLib.Settings GetChild(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = g_settings_get_child(Handle, native_name);
			GLib.Settings ret = GLib.Object.GetObject(raw_ret) as GLib.Settings;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_get_default_value(IntPtr raw, IntPtr key);

		public GLib.Variant GetDefaultValue(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr raw_ret = g_settings_get_default_value(Handle, native_key);
			GLib.Variant ret = new GLib.Variant(raw_ret);
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double g_settings_get_double(IntPtr raw, IntPtr key);

		public double GetDouble(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			double raw_ret = g_settings_get_double(Handle, native_key);
			double ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_settings_get_enum(IntPtr raw, IntPtr key);

		public int GetEnum(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			int raw_ret = g_settings_get_enum(Handle, native_key);
			int ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_settings_get_flags(IntPtr raw, IntPtr key);

		public uint GetFlags(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			uint raw_ret = g_settings_get_flags(Handle, native_key);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_settings_get_int(IntPtr raw, IntPtr key);

		public int GetInt(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			int raw_ret = g_settings_get_int(Handle, native_key);
			int ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern long g_settings_get_int64(IntPtr raw, IntPtr key);

		public long GetInt64(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			long raw_ret = g_settings_get_int64(Handle, native_key);
			long ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_get_mapped(IntPtr raw, IntPtr key, GLibSharp.SettingsGetMappingNative mapping, IntPtr user_data);

		public IntPtr GetMapped(string key, GLib.SettingsGetMapping mapping) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			GLibSharp.SettingsGetMappingWrapper mapping_wrapper = new GLibSharp.SettingsGetMappingWrapper (mapping);
			IntPtr raw_ret = g_settings_get_mapped(Handle, native_key, mapping_wrapper.NativeDelegate, IntPtr.Zero);
			IntPtr ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_get_mapping(IntPtr value, IntPtr variant, IntPtr user_data);

		public static bool GetMapping(GLib.Value value, GLib.Variant variant, IntPtr user_data) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			bool raw_ret = g_settings_get_mapping(native_value, variant == null ? IntPtr.Zero : variant.Handle, user_data);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_get_range(IntPtr raw, IntPtr key);

		[Obsolete]
		public GLib.Variant GetRange(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr raw_ret = g_settings_get_range(Handle, native_key);
			GLib.Variant ret = new GLib.Variant(raw_ret);
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_get_string(IntPtr raw, IntPtr key);

		public string GetString(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr raw_ret = g_settings_get_string(Handle, native_key);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_get_strv(IntPtr raw, IntPtr key);

		public string[] GetStrv(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr raw_ret = g_settings_get_strv(Handle, native_key);
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, true);
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_settings_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint g_settings_get_uint(IntPtr raw, IntPtr key);

		public uint GetUint(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			uint raw_ret = g_settings_get_uint(Handle, native_key);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern ulong g_settings_get_uint64(IntPtr raw, IntPtr key);

		public ulong GetUint64(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			ulong raw_ret = g_settings_get_uint64(Handle, native_key);
			ulong ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_get_user_value(IntPtr raw, IntPtr key);

		public GLib.Variant GetUserValue(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr raw_ret = g_settings_get_user_value(Handle, native_key);
			GLib.Variant ret = new GLib.Variant(raw_ret);
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_get_value(IntPtr raw, IntPtr key);

		public GLib.Variant GetValue(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr raw_ret = g_settings_get_value(Handle, native_key);
			GLib.Variant ret = new GLib.Variant(raw_ret);
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_is_writable(IntPtr raw, IntPtr name);

		public bool IsWritable(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			bool raw_ret = g_settings_is_writable(Handle, native_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_list_children(IntPtr raw);

		public string[] ListChildren() {
			IntPtr raw_ret = g_settings_list_children(Handle);
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, true);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_list_keys(IntPtr raw);

		[Obsolete]
		public string[] ListKeys() {
			IntPtr raw_ret = g_settings_list_keys(Handle);
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, true);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_list_relocatable_schemas();

		[Obsolete]
		public static string[] ListRelocatableSchemas() {
			IntPtr raw_ret = g_settings_list_relocatable_schemas();
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_list_schemas();

		[Obsolete]
		public static string[] ListSchemas() {
			IntPtr raw_ret = g_settings_list_schemas();
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_mapping_is_compatible(IntPtr gvalue_type, IntPtr variant_type);

		public static bool MappingIsCompatible(GLib.GType gvalue_type, GLib.VariantType variant_type) {
			bool raw_ret = g_settings_mapping_is_compatible(gvalue_type.Val, variant_type == null ? IntPtr.Zero : variant_type.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_range_check(IntPtr raw, IntPtr key, IntPtr value);

		[Obsolete]
		public bool RangeCheck(string key, GLib.Variant value) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			bool raw_ret = g_settings_range_check(Handle, native_key, value == null ? IntPtr.Zero : value.Handle);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_settings_reset(IntPtr raw, IntPtr key);

		public void Reset(string key) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			g_settings_reset(Handle, native_key);
			GLib.Marshaller.Free (native_key);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_settings_revert(IntPtr raw);

		public void Revert() {
			g_settings_revert(Handle);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_set_boolean(IntPtr raw, IntPtr key, bool value);

		public bool SetBoolean(string key, bool value) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			bool raw_ret = g_settings_set_boolean(Handle, native_key, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_set_double(IntPtr raw, IntPtr key, double value);

		public bool SetDouble(string key, double value) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			bool raw_ret = g_settings_set_double(Handle, native_key, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_set_enum(IntPtr raw, IntPtr key, int value);

		public bool SetEnum(string key, int value) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			bool raw_ret = g_settings_set_enum(Handle, native_key, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_set_flags(IntPtr raw, IntPtr key, uint value);

		public bool SetFlags(string key, uint value) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			bool raw_ret = g_settings_set_flags(Handle, native_key, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_set_int(IntPtr raw, IntPtr key, int value);

		public bool SetInt(string key, int value) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			bool raw_ret = g_settings_set_int(Handle, native_key, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_set_int64(IntPtr raw, IntPtr key, long value);

		public bool SetInt64(string key, long value) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			bool raw_ret = g_settings_set_int64(Handle, native_key, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_settings_set_mapping(IntPtr value, IntPtr expected_type, IntPtr user_data);

		public static GLib.Variant SetMapping(GLib.Value value, GLib.VariantType expected_type, IntPtr user_data) {
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			IntPtr raw_ret = g_settings_set_mapping(native_value, expected_type == null ? IntPtr.Zero : expected_type.Handle, user_data);
			GLib.Variant ret = new GLib.Variant(raw_ret);
			Marshal.FreeHGlobal (native_value);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_set_string(IntPtr raw, IntPtr key, IntPtr value);

		public bool SetString(string key, string value) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
			bool raw_ret = g_settings_set_string(Handle, native_key, native_value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			GLib.Marshaller.Free (native_value);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_set_strv(IntPtr raw, IntPtr key, IntPtr[] value);

		public bool SetStrv(string key, string[] value) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			int cnt_value = value == null ? 0 : value.Length;
			IntPtr[] native_value = new IntPtr [cnt_value + 1];
			for (int i = 0; i < cnt_value; i++)
				native_value [i] = GLib.Marshaller.StringToPtrGStrdup (value[i]);
			native_value [cnt_value] = IntPtr.Zero;
			bool raw_ret = g_settings_set_strv(Handle, native_key, native_value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			for (int i = 0; i < native_value.Length - 1; i++) {
				value [i] = GLib.Marshaller.Utf8PtrToString (native_value[i]);
				GLib.Marshaller.Free (native_value[i]);
			}
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_set_uint(IntPtr raw, IntPtr key, uint value);

		public bool SetUint(string key, uint value) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			bool raw_ret = g_settings_set_uint(Handle, native_key, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_set_uint64(IntPtr raw, IntPtr key, ulong value);

		public bool SetUint64(string key, ulong value) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			bool raw_ret = g_settings_set_uint64(Handle, native_key, value);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_settings_set_value(IntPtr raw, IntPtr key, IntPtr value);

		public bool SetValue(string key, GLib.Variant value) {
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			bool raw_ret = g_settings_set_value(Handle, native_key, value == null ? IntPtr.Zero : value.Handle);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_key);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_settings_sync();

		public static void Sync() {
			g_settings_sync();
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_settings_unbind(IntPtr objekt, IntPtr property);

		public static void Unbind(IntPtr objekt, string property) {
			IntPtr native_property = GLib.Marshaller.StringToPtrGStrdup (property);
			g_settings_unbind(objekt, native_property);
			GLib.Marshaller.Free (native_property);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
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
