// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GL {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class GLBaseSrc : Gst.Base.PushSrc {

		protected GLBaseSrc (IntPtr raw) : base(raw) {}

		protected GLBaseSrc() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("timestamp-offset")]
		public long TimestampOffset {
			get {
				GLib.Value val = GetProperty ("timestamp-offset");
				long ret = (long) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("timestamp-offset", val);
				val.Dispose ();
			}
		}

		public Gst.GL.GLDisplay Display {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("display"));
					return GLib.Object.GetObject((*raw_ptr)) as Gst.GL.GLDisplay;
				}
			}
		}

		public Gst.GL.GLContext Context {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("context"));
					return GLib.Object.GetObject((*raw_ptr)) as Gst.GL.GLContext;
				}
			}
		}

		public Gst.Video.VideoInfo OutInfo {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("out_info"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Gst.Video.VideoInfo) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Gst.Video.VideoInfo), false);
				}
			}
		}

		public Gst.Caps OutCaps {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("out_caps"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Gst.Caps), false);
				}
			}
		}

		public ulong RunningTime {
			get {
				unsafe {
					ulong* raw_ptr = (ulong*)(((byte*)Handle) + abi_info.GetFieldOffset("running_time"));
					return (*raw_ptr);
				}
			}
		}

		static GlStartNativeDelegate GlStart_cb_delegate;
		static GlStartNativeDelegate GlStartVMCallback {
			get {
				if (GlStart_cb_delegate == null)
					GlStart_cb_delegate = new GlStartNativeDelegate (GlStart_cb);
				return GlStart_cb_delegate;
			}
		}

		static void OverrideGlStart (GLib.GType gtype)
		{
			OverrideGlStart (gtype, GlStartVMCallback);
		}

		static void OverrideGlStart (GLib.GType gtype, GlStartNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("gl_start"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool GlStartNativeDelegate (IntPtr inst);

		static bool GlStart_cb (IntPtr inst)
		{
			try {
				GLBaseSrc __obj = GLib.Object.GetObject (inst, false) as GLBaseSrc;
				bool __result;
				__result = __obj.OnGlStart ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLBaseSrc), ConnectionMethod="OverrideGlStart")]
		protected virtual bool OnGlStart ()
		{
			return InternalGlStart ();
		}

		private bool InternalGlStart ()
		{
			GlStartNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("gl_start"));
				unmanaged = (GlStartNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GlStartNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle);
			return __result;
		}

		static GlStopNativeDelegate GlStop_cb_delegate;
		static GlStopNativeDelegate GlStopVMCallback {
			get {
				if (GlStop_cb_delegate == null)
					GlStop_cb_delegate = new GlStopNativeDelegate (GlStop_cb);
				return GlStop_cb_delegate;
			}
		}

		static void OverrideGlStop (GLib.GType gtype)
		{
			OverrideGlStop (gtype, GlStopVMCallback);
		}

		static void OverrideGlStop (GLib.GType gtype, GlStopNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("gl_stop"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GlStopNativeDelegate (IntPtr inst);

		static void GlStop_cb (IntPtr inst)
		{
			try {
				GLBaseSrc __obj = GLib.Object.GetObject (inst, false) as GLBaseSrc;
				__obj.OnGlStop ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLBaseSrc), ConnectionMethod="OverrideGlStop")]
		protected virtual void OnGlStop ()
		{
			InternalGlStop ();
		}

		private void InternalGlStop ()
		{
			GlStopNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("gl_stop"));
				unmanaged = (GlStopNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GlStopNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static FillGlMemoryNativeDelegate FillGlMemory_cb_delegate;
		static FillGlMemoryNativeDelegate FillGlMemoryVMCallback {
			get {
				if (FillGlMemory_cb_delegate == null)
					FillGlMemory_cb_delegate = new FillGlMemoryNativeDelegate (FillGlMemory_cb);
				return FillGlMemory_cb_delegate;
			}
		}

		static void OverrideFillGlMemory (GLib.GType gtype)
		{
			OverrideFillGlMemory (gtype, FillGlMemoryVMCallback);
		}

		static void OverrideFillGlMemory (GLib.GType gtype, FillGlMemoryNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("fill_gl_memory"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool FillGlMemoryNativeDelegate (IntPtr inst, IntPtr mem);

		static bool FillGlMemory_cb (IntPtr inst, IntPtr mem)
		{
			try {
				GLBaseSrc __obj = GLib.Object.GetObject (inst, false) as GLBaseSrc;
				bool __result;
				__result = __obj.OnFillGlMemory (Gst.GL.GLMemory.New (mem));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLBaseSrc), ConnectionMethod="OverrideFillGlMemory")]
		protected virtual bool OnFillGlMemory (Gst.GL.GLMemory mem)
		{
			return InternalFillGlMemory (mem);
		}

		private bool InternalFillGlMemory (Gst.GL.GLMemory mem)
		{
			FillGlMemoryNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("fill_gl_memory"));
				unmanaged = (FillGlMemoryNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(FillGlMemoryNativeDelegate));
			}
			if (unmanaged == null) return false;

			IntPtr native_mem = GLib.Marshaller.StructureToPtrAlloc (mem);
			bool __result = unmanaged (this.Handle, native_mem);
			Marshal.FreeHGlobal (native_mem);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("supported_gl_api"
							, Gst.Base.PushSrc.class_abi.Fields
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gst.GL.GLAPI))) // supported_gl_api
							, null
							, "gl_start"
							, (long) Marshal.OffsetOf(typeof(GstGLBaseSrc_supported_gl_apiAlign), "supported_gl_api")
							, 0
							),
						new GLib.AbiField("gl_start"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // gl_start
							, "supported_gl_api"
							, "gl_stop"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("gl_stop"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // gl_stop
							, "gl_start"
							, "fill_gl_memory"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("fill_gl_memory"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // fill_gl_memory
							, "gl_stop"
							, "_padding"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_padding"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _padding
							, "fill_gl_memory"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstGLBaseSrc_supported_gl_apiAlign
		{
			sbyte f1;
			private Gst.GL.GLAPI supported_gl_api;
		}


		// End of the ABI representation.

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_base_src_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_gl_base_src_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static GLBaseSrc ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("display"
							, Gst.Base.PushSrc.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // display
							, null
							, "context"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("context"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // context
							, "display"
							, "out_info"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("out_info"
							, -1
							, Gst.Video.VideoInfo.abi_info.Size // out_info
							, "context"
							, "out_caps"
							, Gst.Video.VideoInfo.abi_info.Align
							, 0
							),
						new GLib.AbiField("out_caps"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // out_caps
							, "out_info"
							, "running_time"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("running_time"
							, -1
							, (uint) Marshal.SizeOf(typeof(ulong)) // running_time
							, "out_caps"
							, "_padding"
							, (long) Marshal.OffsetOf(typeof(GstGLBaseSrc_running_timeAlign), "running_time")
							, 0
							),
						new GLib.AbiField("_padding"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _padding
							, "running_time"
							, "priv"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("priv"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, "_padding"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstGLBaseSrc_running_timeAlign
		{
			sbyte f1;
			private ulong running_time;
		}


		// End of the ABI representation.

#endregion
	}
}
