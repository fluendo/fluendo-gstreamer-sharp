// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GL {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class GLFilter : Gst.GL.GLBaseFilter {

		public GLFilter (IntPtr raw) : base(raw) {}

		protected GLFilter() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		public Gst.Video.VideoInfo InInfo {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("in_info"));
					return (*raw_ptr) == IntPtr.Zero ? null : (Gst.Video.VideoInfo) GLib.Opaque.GetOpaque ((*raw_ptr), typeof (Gst.Video.VideoInfo), false);
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

		public Gst.GL.GLTextureTarget InTextureTarget {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("in_texture_target"));
					return (Gst.GL.GLTextureTarget) (*raw_ptr);
				}
			}
		}

		public Gst.GL.GLTextureTarget OutTextureTarget {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("out_texture_target"));
					return (Gst.GL.GLTextureTarget) (*raw_ptr);
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

		public Gst.GL.GLFramebuffer Fbo {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("fbo"));
					return GLib.Object.GetObject((*raw_ptr)) as Gst.GL.GLFramebuffer;
				}
			}
		}

		static SetCapsNativeDelegate SetCaps_cb_delegate;
		static SetCapsNativeDelegate SetCapsVMCallback {
			get {
				if (SetCaps_cb_delegate == null)
					SetCaps_cb_delegate = new SetCapsNativeDelegate (SetCaps_cb);
				return SetCaps_cb_delegate;
			}
		}

		static void OverrideSetCaps (GLib.GType gtype)
		{
			OverrideSetCaps (gtype, SetCapsVMCallback);
		}

		static void OverrideSetCaps (GLib.GType gtype, SetCapsNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("set_caps"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool SetCapsNativeDelegate (IntPtr inst, IntPtr incaps, IntPtr outcaps);

		static bool SetCaps_cb (IntPtr inst, IntPtr incaps, IntPtr outcaps)
		{
			try {
				GLFilter __obj = GLib.Object.GetObject (inst, false) as GLFilter;
				bool __result;
				__result = __obj.OnSetCaps (incaps == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (incaps, typeof (Gst.Caps), false), outcaps == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (outcaps, typeof (Gst.Caps), false));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLFilter), ConnectionMethod="OverrideSetCaps")]
		protected virtual bool OnSetCaps (Gst.Caps incaps, Gst.Caps outcaps)
		{
			return InternalSetCaps (incaps, outcaps);
		}

		private bool InternalSetCaps (Gst.Caps incaps, Gst.Caps outcaps)
		{
			SetCapsNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("set_caps"));
				unmanaged = (SetCapsNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SetCapsNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, incaps == null ? IntPtr.Zero : incaps.Handle, outcaps == null ? IntPtr.Zero : outcaps.Handle);
			return __result;
		}

		static FilterNativeDelegate Filter_cb_delegate;
		static FilterNativeDelegate FilterVMCallback {
			get {
				if (Filter_cb_delegate == null)
					Filter_cb_delegate = new FilterNativeDelegate (Filter_cb);
				return Filter_cb_delegate;
			}
		}

		static void OverrideFilter (GLib.GType gtype)
		{
			OverrideFilter (gtype, FilterVMCallback);
		}

		static void OverrideFilter (GLib.GType gtype, FilterNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("filter"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool FilterNativeDelegate (IntPtr inst, IntPtr inbuf, IntPtr outbuf);

		static bool Filter_cb (IntPtr inst, IntPtr inbuf, IntPtr outbuf)
		{
			try {
				GLFilter __obj = GLib.Object.GetObject (inst, false) as GLFilter;
				bool __result;
				__result = __obj.OnFilter (inbuf == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (inbuf, typeof (Gst.Buffer), false), outbuf == IntPtr.Zero ? null : (Gst.Buffer) GLib.Opaque.GetOpaque (outbuf, typeof (Gst.Buffer), false));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLFilter), ConnectionMethod="OverrideFilter")]
		protected virtual bool OnFilter (Gst.Buffer inbuf, Gst.Buffer outbuf)
		{
			return InternalFilter (inbuf, outbuf);
		}

		private bool InternalFilter (Gst.Buffer inbuf, Gst.Buffer outbuf)
		{
			FilterNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("filter"));
				unmanaged = (FilterNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(FilterNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle, inbuf == null ? IntPtr.Zero : inbuf.Handle, outbuf == null ? IntPtr.Zero : outbuf.Handle);
			return __result;
		}

		static FilterTextureNativeDelegate FilterTexture_cb_delegate;
		static FilterTextureNativeDelegate FilterTextureVMCallback {
			get {
				if (FilterTexture_cb_delegate == null)
					FilterTexture_cb_delegate = new FilterTextureNativeDelegate (FilterTexture_cb);
				return FilterTexture_cb_delegate;
			}
		}

		static void OverrideFilterTexture (GLib.GType gtype)
		{
			OverrideFilterTexture (gtype, FilterTextureVMCallback);
		}

		static void OverrideFilterTexture (GLib.GType gtype, FilterTextureNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("filter_texture"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool FilterTextureNativeDelegate (IntPtr inst, IntPtr input, IntPtr output);

		static bool FilterTexture_cb (IntPtr inst, IntPtr input, IntPtr output)
		{
			try {
				GLFilter __obj = GLib.Object.GetObject (inst, false) as GLFilter;
				bool __result;
				__result = __obj.OnFilterTexture (Gst.GL.GLMemory.New (input), Gst.GL.GLMemory.New (output));
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLFilter), ConnectionMethod="OverrideFilterTexture")]
		protected virtual bool OnFilterTexture (Gst.GL.GLMemory input, Gst.GL.GLMemory output)
		{
			return InternalFilterTexture (input, output);
		}

		private bool InternalFilterTexture (Gst.GL.GLMemory input, Gst.GL.GLMemory output)
		{
			FilterTextureNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("filter_texture"));
				unmanaged = (FilterTextureNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(FilterTextureNativeDelegate));
			}
			if (unmanaged == null) return false;

			IntPtr native_input = GLib.Marshaller.StructureToPtrAlloc (input);
			IntPtr native_output = GLib.Marshaller.StructureToPtrAlloc (output);
			bool __result = unmanaged (this.Handle, native_input, native_output);
			Marshal.FreeHGlobal (native_input);
			Marshal.FreeHGlobal (native_output);
			return __result;
		}

		static InitFboNativeDelegate InitFbo_cb_delegate;
		static InitFboNativeDelegate InitFboVMCallback {
			get {
				if (InitFbo_cb_delegate == null)
					InitFbo_cb_delegate = new InitFboNativeDelegate (InitFbo_cb);
				return InitFbo_cb_delegate;
			}
		}

		static void OverrideInitFbo (GLib.GType gtype)
		{
			OverrideInitFbo (gtype, InitFboVMCallback);
		}

		static void OverrideInitFbo (GLib.GType gtype, InitFboNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("init_fbo"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool InitFboNativeDelegate (IntPtr inst);

		static bool InitFbo_cb (IntPtr inst)
		{
			try {
				GLFilter __obj = GLib.Object.GetObject (inst, false) as GLFilter;
				bool __result;
				__result = __obj.OnInitFbo ();
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLFilter), ConnectionMethod="OverrideInitFbo")]
		protected virtual bool OnInitFbo ()
		{
			return InternalInitFbo ();
		}

		private bool InternalInitFbo ()
		{
			InitFboNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("init_fbo"));
				unmanaged = (InitFboNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(InitFboNativeDelegate));
			}
			if (unmanaged == null) return false;

			bool __result = unmanaged (this.Handle);
			return __result;
		}

		static TransformInternalCapsNativeDelegate TransformInternalCaps_cb_delegate;
		static TransformInternalCapsNativeDelegate TransformInternalCapsVMCallback {
			get {
				if (TransformInternalCaps_cb_delegate == null)
					TransformInternalCaps_cb_delegate = new TransformInternalCapsNativeDelegate (TransformInternalCaps_cb);
				return TransformInternalCaps_cb_delegate;
			}
		}

		static void OverrideTransformInternalCaps (GLib.GType gtype)
		{
			OverrideTransformInternalCaps (gtype, TransformInternalCapsVMCallback);
		}

		static void OverrideTransformInternalCaps (GLib.GType gtype, TransformInternalCapsNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("transform_internal_caps"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr TransformInternalCapsNativeDelegate (IntPtr inst, int direction, IntPtr caps, IntPtr filter_caps);

		static IntPtr TransformInternalCaps_cb (IntPtr inst, int direction, IntPtr caps, IntPtr filter_caps)
		{
			try {
				GLFilter __obj = GLib.Object.GetObject (inst, false) as GLFilter;
				Gst.Caps __result;
				__result = __obj.OnTransformInternalCaps ((Gst.PadDirection) direction, caps == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (caps, typeof (Gst.Caps), false), filter_caps == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (filter_caps, typeof (Gst.Caps), false));
				return __result == null ? IntPtr.Zero : __result.OwnedCopy;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gst.GL.GLFilter), ConnectionMethod="OverrideTransformInternalCaps")]
		protected virtual Gst.Caps OnTransformInternalCaps (Gst.PadDirection direction, Gst.Caps caps, Gst.Caps filter_caps)
		{
			return InternalTransformInternalCaps (direction, caps, filter_caps);
		}

		private Gst.Caps InternalTransformInternalCaps (Gst.PadDirection direction, Gst.Caps caps, Gst.Caps filter_caps)
		{
			TransformInternalCapsNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("transform_internal_caps"));
				unmanaged = (TransformInternalCapsNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(TransformInternalCapsNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle, (int) direction, caps == null ? IntPtr.Zero : caps.Handle, filter_caps == null ? IntPtr.Zero : filter_caps.Handle);
			return __result == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (__result, typeof (Gst.Caps), true);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("set_caps"
							, Gst.GL.GLBaseFilter.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // set_caps
							, null
							, "filter"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("filter"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // filter
							, "set_caps"
							, "filter_texture"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("filter_texture"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // filter_texture
							, "filter"
							, "init_fbo"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("init_fbo"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // init_fbo
							, "filter_texture"
							, "transform_internal_caps"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("transform_internal_caps"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // transform_internal_caps
							, "init_fbo"
							, "_padding"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_padding"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _padding
							, "transform_internal_caps"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_filter_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_gl_filter_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_filter_draw_fullscreen_quad(IntPtr raw);

		public void DrawFullscreenQuad() {
			gst_gl_filter_draw_fullscreen_quad(Handle);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_gl_filter_filter_texture(IntPtr raw, IntPtr input, IntPtr output);

		public bool FilterTexture(Gst.Buffer input, Gst.Buffer output) {
			bool raw_ret = gst_gl_filter_filter_texture(Handle, input == null ? IntPtr.Zero : input.Handle, output == null ? IntPtr.Zero : output.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_gl_filter_render_to_target(IntPtr raw, IntPtr input, IntPtr output, Gst.GLSharp.GLFilterRenderFuncNative func, IntPtr data);

		public bool RenderToTarget(Gst.GL.GLMemory input, Gst.GL.GLMemory output, Gst.GL.GLFilterRenderFunc func) {
			IntPtr native_input = GLib.Marshaller.StructureToPtrAlloc (input);
			IntPtr native_output = GLib.Marshaller.StructureToPtrAlloc (output);
			Gst.GLSharp.GLFilterRenderFuncWrapper func_wrapper = new Gst.GLSharp.GLFilterRenderFuncWrapper (func);
			bool raw_ret = gst_gl_filter_render_to_target(Handle, native_input, native_output, func_wrapper.NativeDelegate, IntPtr.Zero);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_input);
			Marshal.FreeHGlobal (native_output);
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_filter_render_to_target_with_shader(IntPtr raw, IntPtr input, IntPtr output, IntPtr shader);

		public void RenderToTargetWithShader(Gst.GL.GLMemory input, Gst.GL.GLMemory output, Gst.GL.GLShader shader) {
			IntPtr native_input = GLib.Marshaller.StructureToPtrAlloc (input);
			IntPtr native_output = GLib.Marshaller.StructureToPtrAlloc (output);
			gst_gl_filter_render_to_target_with_shader(Handle, native_input, native_output, shader == null ? IntPtr.Zero : shader.Handle);
			Marshal.FreeHGlobal (native_input);
			Marshal.FreeHGlobal (native_output);
		}


		static GLFilter ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("in_info"
							, Gst.GL.GLBaseFilter.abi_info.Fields
							, Gst.Video.VideoInfo.abi_info.Size // in_info
							, null
							, "out_info"
							, Gst.Video.VideoInfo.abi_info.Align
							, 0
							),
						new GLib.AbiField("out_info"
							, -1
							, Gst.Video.VideoInfo.abi_info.Size // out_info
							, "in_info"
							, "in_texture_target"
							, Gst.Video.VideoInfo.abi_info.Align
							, 0
							),
						new GLib.AbiField("in_texture_target"
							, -1
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gst.GL.GLTextureTarget))) // in_texture_target
							, "out_info"
							, "out_texture_target"
							, (long) Marshal.OffsetOf(typeof(GstGLFilter_in_texture_targetAlign), "in_texture_target")
							, 0
							),
						new GLib.AbiField("out_texture_target"
							, -1
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gst.GL.GLTextureTarget))) // out_texture_target
							, "in_texture_target"
							, "out_caps"
							, (long) Marshal.OffsetOf(typeof(GstGLFilter_out_texture_targetAlign), "out_texture_target")
							, 0
							),
						new GLib.AbiField("out_caps"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // out_caps
							, "out_texture_target"
							, "fbo"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("fbo"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // fbo
							, "out_caps"
							, "gl_result"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("gl_result"
							, -1
							, (uint) Marshal.SizeOf(typeof(bool)) // gl_result
							, "fbo"
							, "inbuf"
							, (long) Marshal.OffsetOf(typeof(GstGLFilter_gl_resultAlign), "gl_result")
							, 0
							),
						new GLib.AbiField("inbuf"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // inbuf
							, "gl_result"
							, "outbuf"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("outbuf"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // outbuf
							, "inbuf"
							, "default_shader"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("default_shader"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // default_shader
							, "outbuf"
							, "valid_attributes"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("valid_attributes"
							, -1
							, (uint) Marshal.SizeOf(typeof(bool)) // valid_attributes
							, "default_shader"
							, "vao"
							, (long) Marshal.OffsetOf(typeof(GstGLFilter_valid_attributesAlign), "valid_attributes")
							, 0
							),
						new GLib.AbiField("vao"
							, -1
							, (uint) Marshal.SizeOf(typeof(uint)) // vao
							, "valid_attributes"
							, "vbo_indices"
							, (long) Marshal.OffsetOf(typeof(GstGLFilter_vaoAlign), "vao")
							, 0
							),
						new GLib.AbiField("vbo_indices"
							, -1
							, (uint) Marshal.SizeOf(typeof(uint)) // vbo_indices
							, "vao"
							, "vertex_buffer"
							, (long) Marshal.OffsetOf(typeof(GstGLFilter_vbo_indicesAlign), "vbo_indices")
							, 0
							),
						new GLib.AbiField("vertex_buffer"
							, -1
							, (uint) Marshal.SizeOf(typeof(uint)) // vertex_buffer
							, "vbo_indices"
							, "draw_attr_position_loc"
							, (long) Marshal.OffsetOf(typeof(GstGLFilter_vertex_bufferAlign), "vertex_buffer")
							, 0
							),
						new GLib.AbiField("draw_attr_position_loc"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // draw_attr_position_loc
							, "vertex_buffer"
							, "draw_attr_texture_loc"
							, (long) Marshal.OffsetOf(typeof(GstGLFilter_draw_attr_position_locAlign), "draw_attr_position_loc")
							, 0
							),
						new GLib.AbiField("draw_attr_texture_loc"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // draw_attr_texture_loc
							, "draw_attr_position_loc"
							, "_padding"
							, (long) Marshal.OffsetOf(typeof(GstGLFilter_draw_attr_texture_locAlign), "draw_attr_texture_loc")
							, 0
							),
						new GLib.AbiField("_padding"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _padding
							, "draw_attr_texture_loc"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstGLFilter_in_texture_targetAlign
		{
			sbyte f1;
			private Gst.GL.GLTextureTarget in_texture_target;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstGLFilter_out_texture_targetAlign
		{
			sbyte f1;
			private Gst.GL.GLTextureTarget out_texture_target;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstGLFilter_gl_resultAlign
		{
			sbyte f1;
			private bool gl_result;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstGLFilter_valid_attributesAlign
		{
			sbyte f1;
			private bool valid_attributes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstGLFilter_vaoAlign
		{
			sbyte f1;
			private uint vao;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstGLFilter_vbo_indicesAlign
		{
			sbyte f1;
			private uint vbo_indices;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstGLFilter_vertex_bufferAlign
		{
			sbyte f1;
			private uint vertex_buffer;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstGLFilter_draw_attr_position_locAlign
		{
			sbyte f1;
			private int draw_attr_position_loc;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstGLFilter_draw_attr_texture_locAlign
		{
			sbyte f1;
			private int draw_attr_texture_loc;
		}


		// End of the ABI representation.

#endregion
	}
}
