// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GL {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class GLAsyncDebug : GLib.Opaque {

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_async_debug_freeze(IntPtr raw);

		public void Freeze() {
			gst_gl_async_debug_freeze(Handle);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_async_debug_init(IntPtr raw);

		public void Init() {
			gst_gl_async_debug_init(Handle);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_async_debug_output_log_msg(IntPtr raw);

		public void OutputLogMsg() {
			gst_gl_async_debug_output_log_msg(Handle);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_async_debug_thaw(IntPtr raw);

		public void Thaw() {
			gst_gl_async_debug_thaw(Handle);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_async_debug_unset(IntPtr raw);

		public void Unset() {
			gst_gl_async_debug_unset(Handle);
		}

		public GLAsyncDebug(IntPtr raw) : base(raw) {}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_async_debug_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gst_gl_async_debug_free (raw);
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return gst_gl_async_debug_free;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("state_flags"
							, 0
							, (uint) Marshal.SizeOf(typeof(uint)) // state_flags
							, null
							, "cat"
							, (long) Marshal.OffsetOf(typeof(GstGLAsyncDebug_state_flagsAlign), "state_flags")
							, 0
							),
						new GLib.AbiField("cat"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // cat
							, "state_flags"
							, "level"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("level"
							, -1
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gst.DebugLevel))) // level
							, "cat"
							, "file"
							, (long) Marshal.OffsetOf(typeof(GstGLAsyncDebug_levelAlign), "level")
							, 0
							),
						new GLib.AbiField("file"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // file
							, "level"
							, "function"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("function"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // function
							, "file"
							, "line"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("line"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // line
							, "function"
							, "object"
							, (long) Marshal.OffsetOf(typeof(GstGLAsyncDebug_lineAlign), "line")
							, 0
							),
						new GLib.AbiField("object"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // object
							, "line"
							, "debug_msg"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("debug_msg"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // debug_msg
							, "object"
							, "callback"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("callback"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // callback
							, "debug_msg"
							, "user_data"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("user_data"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // user_data
							, "callback"
							, "notify"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("notify"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // notify
							, "user_data"
							, "_padding"
							, (long) Marshal.OffsetOf(typeof(GstGLAsyncDebug_notifyAlign), "notify")
							, 0
							),
						new GLib.AbiField("_padding"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _padding
							, "notify"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstGLAsyncDebug_state_flagsAlign
		{
			sbyte f1;
			private uint state_flags;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstGLAsyncDebug_levelAlign
		{
			sbyte f1;
			private Gst.DebugLevel level;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstGLAsyncDebug_lineAlign
		{
			sbyte f1;
			private int line;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstGLAsyncDebug_notifyAlign
		{
			sbyte f1;
			private GLib.DestroyNotify notify;
		}


		// End of the ABI representation.

#endregion
	}
}
