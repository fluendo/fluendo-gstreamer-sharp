// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class MenuModel : GLib.Object {

		public MenuModel (IntPtr raw) : base(raw) {}

		protected MenuModel() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Signal("items-changed")]
		public event GLib.ItemsChangedHandler ItemsChanged {
			add {
				this.AddSignalHandler ("items-changed", value, typeof (GLib.ItemsChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("items-changed", value);
			}
		}

		static ItemsChangedNativeDelegate ItemsChanged_cb_delegate;
		static ItemsChangedNativeDelegate ItemsChangedVMCallback {
			get {
				if (ItemsChanged_cb_delegate == null)
					ItemsChanged_cb_delegate = new ItemsChangedNativeDelegate (ItemsChanged_cb);
				return ItemsChanged_cb_delegate;
			}
		}

		static void OverrideItemsChanged (GLib.GType gtype)
		{
			OverrideItemsChanged (gtype, ItemsChangedVMCallback);
		}

		static void OverrideItemsChanged (GLib.GType gtype, ItemsChangedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "items-changed", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ItemsChangedNativeDelegate (IntPtr inst, int p0, int p1, int p2);

		static void ItemsChanged_cb (IntPtr inst, int p0, int p1, int p2)
		{
			try {
				MenuModel __obj = GLib.Object.GetObject (inst, false) as MenuModel;
				__obj.OnItemsChanged (p0, p1, p2);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.MenuModel), ConnectionMethod="OverrideItemsChanged")]
		protected virtual void OnItemsChanged (int p0, int p1, int p2)
		{
			InternalItemsChanged (p0, p1, p2);
		}

		private void InternalItemsChanged (int p0, int p1, int p2)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (4);
			GLib.Value[] vals = new GLib.Value [4];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (p0);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (p1);
			inst_and_params.Append (vals [2]);
			vals [3] = new GLib.Value (p2);
			inst_and_params.Append (vals [3]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static IsMutableNativeDelegate IsMutable_cb_delegate;
		static IsMutableNativeDelegate IsMutableVMCallback {
			get {
				if (IsMutable_cb_delegate == null)
					IsMutable_cb_delegate = new IsMutableNativeDelegate (IsMutable_cb);
				return IsMutable_cb_delegate;
			}
		}

		static void OverrideIsMutable (GLib.GType gtype)
		{
			OverrideIsMutable (gtype, IsMutableVMCallback);
		}

		static void OverrideIsMutable (GLib.GType gtype, IsMutableNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("is_mutable"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool IsMutableNativeDelegate (IntPtr inst);

		static bool IsMutable_cb (IntPtr inst)
		{
			try {
				MenuModel __obj = GLib.Object.GetObject (inst, false) as MenuModel;
				bool __result;
				__result = __obj.OnIsMutable ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.MenuModel), ConnectionMethod="OverrideIsMutable")]
		protected virtual bool OnIsMutable ()
		{
			return InternalIsMutable ();
		}

		private bool InternalIsMutable ()
		{
			IsMutableNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("is_mutable"));
				unmanaged = (IsMutableNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(IsMutableNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle);
			return __result;
		}

		static GetNItemsNativeDelegate GetNItems_cb_delegate;
		static GetNItemsNativeDelegate GetNItemsVMCallback {
			get {
				if (GetNItems_cb_delegate == null)
					GetNItems_cb_delegate = new GetNItemsNativeDelegate (GetNItems_cb);
				return GetNItems_cb_delegate;
			}
		}

		static void OverrideGetNItems (GLib.GType gtype)
		{
			OverrideGetNItems (gtype, GetNItemsVMCallback);
		}

		static void OverrideGetNItems (GLib.GType gtype, GetNItemsNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_n_items"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetNItemsNativeDelegate (IntPtr inst);

		static int GetNItems_cb (IntPtr inst)
		{
			try {
				MenuModel __obj = GLib.Object.GetObject (inst, false) as MenuModel;
				int __result;
				__result = __obj.OnGetNItems ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.MenuModel), ConnectionMethod="OverrideGetNItems")]
		protected virtual int OnGetNItems ()
		{
			return InternalGetNItems ();
		}

		private int InternalGetNItems ()
		{
			GetNItemsNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_n_items"));
				unmanaged = (GetNItemsNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetNItemsNativeDelegate));
			}
			if (unmanaged == null) return 0;

			int __result = unmanaged (this.Handle);
			return __result;
		}

		static GetItemAttributesNativeDelegate GetItemAttributes_cb_delegate;
		static GetItemAttributesNativeDelegate GetItemAttributesVMCallback {
			get {
				if (GetItemAttributes_cb_delegate == null)
					GetItemAttributes_cb_delegate = new GetItemAttributesNativeDelegate (GetItemAttributes_cb);
				return GetItemAttributes_cb_delegate;
			}
		}

		static void OverrideGetItemAttributes (GLib.GType gtype)
		{
			OverrideGetItemAttributes (gtype, GetItemAttributesVMCallback);
		}

		static void OverrideGetItemAttributes (GLib.GType gtype, GetItemAttributesNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_item_attributes"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetItemAttributesNativeDelegate (IntPtr inst, int item_index, System.IntPtr attributes);

		static void GetItemAttributes_cb (IntPtr inst, int item_index, System.IntPtr attributes)
		{
			try {
				MenuModel __obj = GLib.Object.GetObject (inst, false) as MenuModel;
				__obj.OnGetItemAttributes (item_index, attributes);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.MenuModel), ConnectionMethod="OverrideGetItemAttributes")]
		protected virtual void OnGetItemAttributes (int item_index, System.IntPtr attributes)
		{
			InternalGetItemAttributes (item_index, attributes);
		}

		private void InternalGetItemAttributes (int item_index, System.IntPtr attributes)
		{
			GetItemAttributesNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_item_attributes"));
				unmanaged = (GetItemAttributesNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetItemAttributesNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, item_index, attributes);
		}

		static IterateItemAttributesNativeDelegate IterateItemAttributes_cb_delegate;
		static IterateItemAttributesNativeDelegate IterateItemAttributesVMCallback {
			get {
				if (IterateItemAttributes_cb_delegate == null)
					IterateItemAttributes_cb_delegate = new IterateItemAttributesNativeDelegate (IterateItemAttributes_cb);
				return IterateItemAttributes_cb_delegate;
			}
		}

		static void OverrideIterateItemAttributes (GLib.GType gtype)
		{
			OverrideIterateItemAttributes (gtype, IterateItemAttributesVMCallback);
		}

		static void OverrideIterateItemAttributes (GLib.GType gtype, IterateItemAttributesNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("iterate_item_attributes"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr IterateItemAttributesNativeDelegate (IntPtr inst, int item_index);

		static IntPtr IterateItemAttributes_cb (IntPtr inst, int item_index)
		{
			try {
				MenuModel __obj = GLib.Object.GetObject (inst, false) as MenuModel;
				GLib.MenuAttributeIter __result;
				__result = __obj.OnIterateItemAttributes (item_index);
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.MenuModel), ConnectionMethod="OverrideIterateItemAttributes")]
		protected virtual GLib.MenuAttributeIter OnIterateItemAttributes (int item_index)
		{
			return InternalIterateItemAttributes (item_index);
		}

		private GLib.MenuAttributeIter InternalIterateItemAttributes (int item_index)
		{
			IterateItemAttributesNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("iterate_item_attributes"));
				unmanaged = (IterateItemAttributesNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(IterateItemAttributesNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, item_index);
			return GLib.Object.GetObject(__result) as GLib.MenuAttributeIter;
		}

		static GetItemAttributeValueNativeDelegate GetItemAttributeValue_cb_delegate;
		static GetItemAttributeValueNativeDelegate GetItemAttributeValueVMCallback {
			get {
				if (GetItemAttributeValue_cb_delegate == null)
					GetItemAttributeValue_cb_delegate = new GetItemAttributeValueNativeDelegate (GetItemAttributeValue_cb);
				return GetItemAttributeValue_cb_delegate;
			}
		}

		static void OverrideGetItemAttributeValue (GLib.GType gtype)
		{
			OverrideGetItemAttributeValue (gtype, GetItemAttributeValueVMCallback);
		}

		static void OverrideGetItemAttributeValue (GLib.GType gtype, GetItemAttributeValueNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_item_attribute_value"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetItemAttributeValueNativeDelegate (IntPtr inst, int item_index, IntPtr attribute, IntPtr expected_type);

		static IntPtr GetItemAttributeValue_cb (IntPtr inst, int item_index, IntPtr attribute, IntPtr expected_type)
		{
			try {
				MenuModel __obj = GLib.Object.GetObject (inst, false) as MenuModel;
				GLib.Variant __result;
				__result = __obj.OnGetItemAttributeValue (item_index, GLib.Marshaller.Utf8PtrToString (attribute), new GLib.VariantType(expected_type));
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.MenuModel), ConnectionMethod="OverrideGetItemAttributeValue")]
		protected virtual GLib.Variant OnGetItemAttributeValue (int item_index, string attribute, GLib.VariantType expected_type)
		{
			return InternalGetItemAttributeValue (item_index, attribute, expected_type);
		}

		private GLib.Variant InternalGetItemAttributeValue (int item_index, string attribute, GLib.VariantType expected_type)
		{
			GetItemAttributeValueNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_item_attribute_value"));
				unmanaged = (GetItemAttributeValueNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetItemAttributeValueNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			IntPtr __result = unmanaged (this.Handle, item_index, native_attribute, expected_type == null ? IntPtr.Zero : expected_type.Handle);
			GLib.Marshaller.Free (native_attribute);
			return new GLib.Variant(__result);
		}

		static GetItemLinksNativeDelegate GetItemLinks_cb_delegate;
		static GetItemLinksNativeDelegate GetItemLinksVMCallback {
			get {
				if (GetItemLinks_cb_delegate == null)
					GetItemLinks_cb_delegate = new GetItemLinksNativeDelegate (GetItemLinks_cb);
				return GetItemLinks_cb_delegate;
			}
		}

		static void OverrideGetItemLinks (GLib.GType gtype)
		{
			OverrideGetItemLinks (gtype, GetItemLinksVMCallback);
		}

		static void OverrideGetItemLinks (GLib.GType gtype, GetItemLinksNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_item_links"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GetItemLinksNativeDelegate (IntPtr inst, int item_index, System.IntPtr links);

		static void GetItemLinks_cb (IntPtr inst, int item_index, System.IntPtr links)
		{
			try {
				MenuModel __obj = GLib.Object.GetObject (inst, false) as MenuModel;
				__obj.OnGetItemLinks (item_index, links);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.MenuModel), ConnectionMethod="OverrideGetItemLinks")]
		protected virtual void OnGetItemLinks (int item_index, System.IntPtr links)
		{
			InternalGetItemLinks (item_index, links);
		}

		private void InternalGetItemLinks (int item_index, System.IntPtr links)
		{
			GetItemLinksNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_item_links"));
				unmanaged = (GetItemLinksNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetItemLinksNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, item_index, links);
		}

		static IterateItemLinksNativeDelegate IterateItemLinks_cb_delegate;
		static IterateItemLinksNativeDelegate IterateItemLinksVMCallback {
			get {
				if (IterateItemLinks_cb_delegate == null)
					IterateItemLinks_cb_delegate = new IterateItemLinksNativeDelegate (IterateItemLinks_cb);
				return IterateItemLinks_cb_delegate;
			}
		}

		static void OverrideIterateItemLinks (GLib.GType gtype)
		{
			OverrideIterateItemLinks (gtype, IterateItemLinksVMCallback);
		}

		static void OverrideIterateItemLinks (GLib.GType gtype, IterateItemLinksNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("iterate_item_links"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr IterateItemLinksNativeDelegate (IntPtr inst, int item_index);

		static IntPtr IterateItemLinks_cb (IntPtr inst, int item_index)
		{
			try {
				MenuModel __obj = GLib.Object.GetObject (inst, false) as MenuModel;
				GLib.MenuLinkIter __result;
				__result = __obj.OnIterateItemLinks (item_index);
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.MenuModel), ConnectionMethod="OverrideIterateItemLinks")]
		protected virtual GLib.MenuLinkIter OnIterateItemLinks (int item_index)
		{
			return InternalIterateItemLinks (item_index);
		}

		private GLib.MenuLinkIter InternalIterateItemLinks (int item_index)
		{
			IterateItemLinksNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("iterate_item_links"));
				unmanaged = (IterateItemLinksNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(IterateItemLinksNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, item_index);
			return GLib.Object.GetObject(__result) as GLib.MenuLinkIter;
		}

		static GetItemLinkNativeDelegate GetItemLink_cb_delegate;
		static GetItemLinkNativeDelegate GetItemLinkVMCallback {
			get {
				if (GetItemLink_cb_delegate == null)
					GetItemLink_cb_delegate = new GetItemLinkNativeDelegate (GetItemLink_cb);
				return GetItemLink_cb_delegate;
			}
		}

		static void OverrideGetItemLink (GLib.GType gtype)
		{
			OverrideGetItemLink (gtype, GetItemLinkVMCallback);
		}

		static void OverrideGetItemLink (GLib.GType gtype, GetItemLinkNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_item_link"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetItemLinkNativeDelegate (IntPtr inst, int item_index, IntPtr link);

		static IntPtr GetItemLink_cb (IntPtr inst, int item_index, IntPtr link)
		{
			try {
				MenuModel __obj = GLib.Object.GetObject (inst, false) as MenuModel;
				GLib.MenuModel __result;
				__result = __obj.OnGetItemLink (item_index, GLib.Marshaller.Utf8PtrToString (link));
				return __result == null ? IntPtr.Zero : __result.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.MenuModel), ConnectionMethod="OverrideGetItemLink")]
		protected virtual GLib.MenuModel OnGetItemLink (int item_index, string link)
		{
			return InternalGetItemLink (item_index, link);
		}

		private GLib.MenuModel InternalGetItemLink (int item_index, string link)
		{
			GetItemLinkNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_item_link"));
				unmanaged = (GetItemLinkNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetItemLinkNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr native_link = GLib.Marshaller.StringToPtrGStrdup (link);
			IntPtr __result = unmanaged (this.Handle, item_index, native_link);
			GLib.Marshaller.Free (native_link);
			return GLib.Object.GetObject(__result) as GLib.MenuModel;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("is_mutable"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // is_mutable
							, null
							, "get_n_items"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_n_items"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_n_items
							, "is_mutable"
							, "get_item_attributes"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_item_attributes"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_item_attributes
							, "get_n_items"
							, "iterate_item_attributes"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("iterate_item_attributes"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // iterate_item_attributes
							, "get_item_attributes"
							, "get_item_attribute_value"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_item_attribute_value"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_item_attribute_value
							, "iterate_item_attributes"
							, "get_item_links"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_item_links"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_item_links
							, "get_item_attribute_value"
							, "iterate_item_links"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("iterate_item_links"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // iterate_item_links
							, "get_item_links"
							, "get_item_link"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_item_link"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_item_link
							, "iterate_item_links"
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
		static extern IntPtr g_menu_model_get_item_attribute_value(IntPtr raw, int item_index, IntPtr attribute, IntPtr expected_type);

		public GLib.Variant GetItemAttributeValue(int item_index, string attribute, GLib.VariantType expected_type) {
			IntPtr native_attribute = GLib.Marshaller.StringToPtrGStrdup (attribute);
			IntPtr raw_ret = g_menu_model_get_item_attribute_value(Handle, item_index, native_attribute, expected_type == null ? IntPtr.Zero : expected_type.Handle);
			GLib.Variant ret = new GLib.Variant(raw_ret);
			GLib.Marshaller.Free (native_attribute);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_menu_model_get_item_link(IntPtr raw, int item_index, IntPtr link);

		public GLib.MenuModel GetItemLink(int item_index, string link) {
			IntPtr native_link = GLib.Marshaller.StringToPtrGStrdup (link);
			IntPtr raw_ret = g_menu_model_get_item_link(Handle, item_index, native_link);
			GLib.MenuModel ret = GLib.Object.GetObject(raw_ret) as GLib.MenuModel;
			GLib.Marshaller.Free (native_link);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int g_menu_model_get_n_items(IntPtr raw);

		public int NItems { 
			get {
				int raw_ret = g_menu_model_get_n_items(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_menu_model_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_menu_model_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_menu_model_is_mutable(IntPtr raw);

		public bool IsMutable { 
			get {
				bool raw_ret = g_menu_model_is_mutable(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_menu_model_items_changed(IntPtr raw, int position, int removed, int added);

		public void SetItemsChanged(int position, int removed, int added) {
			g_menu_model_items_changed(Handle, position, removed, added);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_menu_model_iterate_item_attributes(IntPtr raw, int item_index);

		public GLib.MenuAttributeIter IterateItemAttributes(int item_index) {
			IntPtr raw_ret = g_menu_model_iterate_item_attributes(Handle, item_index);
			GLib.MenuAttributeIter ret = GLib.Object.GetObject(raw_ret) as GLib.MenuAttributeIter;
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_menu_model_iterate_item_links(IntPtr raw, int item_index);

		public GLib.MenuLinkIter IterateItemLinks(int item_index) {
			IntPtr raw_ret = g_menu_model_iterate_item_links(Handle, item_index);
			GLib.MenuLinkIter ret = GLib.Object.GetObject(raw_ret) as GLib.MenuLinkIter;
			return ret;
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
