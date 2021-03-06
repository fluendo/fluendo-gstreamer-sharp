// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GL {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class GLShader : Gst.Object {

		public GLShader (IntPtr raw) : base(raw) {}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_shader_new(IntPtr context);

		public GLShader (Gst.GL.GLContext context) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (GLShader)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gst_gl_shader_new(context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_shader_new_default(IntPtr context);

		public static GLShader NewDefault(Gst.GL.GLContext context)
		{
			GLShader result = new GLShader (gst_gl_shader_new_default(context == null ? IntPtr.Zero : context.Handle));
			return result;
		}

		[GLib.Property ("linked")]
		public bool Linked {
			get {
				GLib.Value val = GetProperty ("linked");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
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


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (Gst.Object.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_shader_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_gl_shader_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_shader_string_fragment_external_oes_get_default(IntPtr context, int version, int profile);

		public static string StringFragmentExternalOesGetDefault(Gst.GL.GLContext context, Gst.GL.GLSLVersion version, Gst.GL.GLSLProfile profile) {
			IntPtr raw_ret = gst_gl_shader_string_fragment_external_oes_get_default(context == null ? IntPtr.Zero : context.Handle, (int) version, (int) profile);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_shader_string_fragment_get_default(IntPtr context, int version, int profile);

		public static string StringFragmentGetDefault(Gst.GL.GLContext context, Gst.GL.GLSLVersion version, Gst.GL.GLSLProfile profile) {
			IntPtr raw_ret = gst_gl_shader_string_fragment_get_default(context == null ? IntPtr.Zero : context.Handle, (int) version, (int) profile);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_shader_string_get_highest_precision(IntPtr context, int version, int profile);

		public static string StringGetHighestPrecision(Gst.GL.GLContext context, Gst.GL.GLSLVersion version, Gst.GL.GLSLProfile profile) {
			IntPtr raw_ret = gst_gl_shader_string_get_highest_precision(context == null ? IntPtr.Zero : context.Handle, (int) version, (int) profile);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_gl_shader_attach(IntPtr raw, IntPtr stage);

		public bool Attach(Gst.GL.GLSLStage stage) {
			bool raw_ret = gst_gl_shader_attach(Handle, stage == null ? IntPtr.Zero : stage.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_gl_shader_attach_unlocked(IntPtr raw, IntPtr stage);

		public bool AttachUnlocked(Gst.GL.GLSLStage stage) {
			bool raw_ret = gst_gl_shader_attach_unlocked(Handle, stage == null ? IntPtr.Zero : stage.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_bind_attribute_location(IntPtr raw, uint index, IntPtr name);

		public void BindAttributeLocation(uint index, string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_bind_attribute_location(Handle, index, native_name);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_bind_frag_data_location(IntPtr raw, uint index, IntPtr name);

		public void BindFragDataLocation(uint index, string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_bind_frag_data_location(Handle, index, native_name);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gst_gl_shader_compile_attach_stage(IntPtr raw, IntPtr stage, out IntPtr error);

		public unsafe bool CompileAttachStage(Gst.GL.GLSLStage stage) {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gst_gl_shader_compile_attach_stage(Handle, stage == null ? IntPtr.Zero : stage.Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_detach(IntPtr raw, IntPtr stage);

		public void Detach(Gst.GL.GLSLStage stage) {
			gst_gl_shader_detach(Handle, stage == null ? IntPtr.Zero : stage.Handle);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_detach_unlocked(IntPtr raw, IntPtr stage);

		public void DetachUnlocked(Gst.GL.GLSLStage stage) {
			gst_gl_shader_detach_unlocked(Handle, stage == null ? IntPtr.Zero : stage.Handle);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_gl_shader_get_attribute_location(IntPtr raw, IntPtr name);

		public int GetAttributeLocation(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			int raw_ret = gst_gl_shader_get_attribute_location(Handle, native_name);
			int ret = raw_ret;
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_gl_shader_get_program_handle(IntPtr raw);

		public int ProgramHandle { 
			get {
				int raw_ret = gst_gl_shader_get_program_handle(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_gl_shader_is_linked(IntPtr raw);

		public bool IsLinked { 
			get {
				bool raw_ret = gst_gl_shader_is_linked(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe bool gst_gl_shader_link(IntPtr raw, out IntPtr error);

		public unsafe bool Link() {
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gst_gl_shader_link(Handle, out error);
			bool ret = raw_ret;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_release(IntPtr raw);

		public void Release() {
			gst_gl_shader_release(Handle);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_release_unlocked(IntPtr raw);

		public void ReleaseUnlocked() {
			gst_gl_shader_release_unlocked(Handle);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_1f(IntPtr raw, IntPtr name, float value);

		public void SetUniform1f(string name, float value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_1f(Handle, native_name, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_1fv(IntPtr raw, IntPtr name, uint count, float[] value);

		public void SetUniform1fv(string name, uint count, float[] value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_1fv(Handle, native_name, count, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_1i(IntPtr raw, IntPtr name, int value);

		public void SetUniform1i(string name, int value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_1i(Handle, native_name, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_1iv(IntPtr raw, IntPtr name, uint count, int[] value);

		public void SetUniform1iv(string name, uint count, int[] value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_1iv(Handle, native_name, count, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_2f(IntPtr raw, IntPtr name, float v0, float v1);

		public void SetUniform2f(string name, float v0, float v1) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_2f(Handle, native_name, v0, v1);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_2fv(IntPtr raw, IntPtr name, uint count, float[] value);

		public void SetUniform2fv(string name, uint count, float[] value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_2fv(Handle, native_name, count, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_2i(IntPtr raw, IntPtr name, int v0, int v1);

		public void SetUniform2i(string name, int v0, int v1) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_2i(Handle, native_name, v0, v1);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_2iv(IntPtr raw, IntPtr name, uint count, int[] value);

		public void SetUniform2iv(string name, uint count, int[] value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_2iv(Handle, native_name, count, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_3f(IntPtr raw, IntPtr name, float v0, float v1, float v2);

		public void SetUniform3f(string name, float v0, float v1, float v2) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_3f(Handle, native_name, v0, v1, v2);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_3fv(IntPtr raw, IntPtr name, uint count, float[] value);

		public void SetUniform3fv(string name, uint count, float[] value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_3fv(Handle, native_name, count, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_3i(IntPtr raw, IntPtr name, int v0, int v1, int v2);

		public void SetUniform3i(string name, int v0, int v1, int v2) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_3i(Handle, native_name, v0, v1, v2);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_3iv(IntPtr raw, IntPtr name, uint count, int[] value);

		public void SetUniform3iv(string name, uint count, int[] value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_3iv(Handle, native_name, count, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_4f(IntPtr raw, IntPtr name, float v0, float v1, float v2, float v3);

		public void SetUniform4f(string name, float v0, float v1, float v2, float v3) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_4f(Handle, native_name, v0, v1, v2, v3);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_4fv(IntPtr raw, IntPtr name, uint count, float[] value);

		public void SetUniform4fv(string name, uint count, float[] value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_4fv(Handle, native_name, count, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_4i(IntPtr raw, IntPtr name, int v0, int v1, int v2, int v3);

		public void SetUniform4i(string name, int v0, int v1, int v2, int v3) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_4i(Handle, native_name, v0, v1, v2, v3);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_4iv(IntPtr raw, IntPtr name, uint count, int[] value);

		public void SetUniform4iv(string name, uint count, int[] value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_4iv(Handle, native_name, count, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_matrix_2fv(IntPtr raw, IntPtr name, int count, bool transpose, float value);

		public void SetUniformMatrix2fv(string name, int count, bool transpose, float value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_matrix_2fv(Handle, native_name, count, transpose, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_matrix_2x3fv(IntPtr raw, IntPtr name, int count, bool transpose, float value);

		public void SetUniformMatrix2x3fv(string name, int count, bool transpose, float value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_matrix_2x3fv(Handle, native_name, count, transpose, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_matrix_2x4fv(IntPtr raw, IntPtr name, int count, bool transpose, float value);

		public void SetUniformMatrix2x4fv(string name, int count, bool transpose, float value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_matrix_2x4fv(Handle, native_name, count, transpose, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_matrix_3fv(IntPtr raw, IntPtr name, int count, bool transpose, float value);

		public void SetUniformMatrix3fv(string name, int count, bool transpose, float value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_matrix_3fv(Handle, native_name, count, transpose, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_matrix_3x2fv(IntPtr raw, IntPtr name, int count, bool transpose, float value);

		public void SetUniformMatrix3x2fv(string name, int count, bool transpose, float value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_matrix_3x2fv(Handle, native_name, count, transpose, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_matrix_3x4fv(IntPtr raw, IntPtr name, int count, bool transpose, float value);

		public void SetUniformMatrix3x4fv(string name, int count, bool transpose, float value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_matrix_3x4fv(Handle, native_name, count, transpose, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_matrix_4fv(IntPtr raw, IntPtr name, int count, bool transpose, float value);

		public void SetUniformMatrix4fv(string name, int count, bool transpose, float value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_matrix_4fv(Handle, native_name, count, transpose, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_matrix_4x2fv(IntPtr raw, IntPtr name, int count, bool transpose, float value);

		public void SetUniformMatrix4x2fv(string name, int count, bool transpose, float value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_matrix_4x2fv(Handle, native_name, count, transpose, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_set_uniform_matrix_4x3fv(IntPtr raw, IntPtr name, int count, bool transpose, float value);

		public void SetUniformMatrix4x3fv(string name, int count, bool transpose, float value) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			gst_gl_shader_set_uniform_matrix_4x3fv(Handle, native_name, count, transpose, value);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_shader_use(IntPtr raw);

		public void Use() {
			gst_gl_shader_use(Handle);
		}


		static GLShader ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("context"
							, Gst.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // context
							, null
							, "priv"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("priv"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, "context"
							, "_padding"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_padding"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _padding
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
