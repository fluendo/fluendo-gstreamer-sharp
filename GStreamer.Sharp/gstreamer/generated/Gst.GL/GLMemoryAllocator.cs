// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GL {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class GLMemoryAllocator : Gst.GL.GLBaseMemoryAllocator {

		public GLMemoryAllocator (IntPtr raw) : base(raw) {}

		protected GLMemoryAllocator() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("map"
							, Gst.GL.GLBaseMemoryAllocator.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // map
							, null
							, "copy"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("copy"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // copy
							, "map"
							, "unmap"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("unmap"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // unmap
							, "copy"
							, "_padding"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_padding"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _padding
							, "unmap"
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
		static extern IntPtr gst_gl_memory_allocator_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_gl_memory_allocator_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_memory_allocator_get_default(IntPtr context);

		public static Gst.GL.GLMemoryAllocator GetDefault(Gst.GL.GLContext context) {
			IntPtr raw_ret = gst_gl_memory_allocator_get_default(context == null ? IntPtr.Zero : context.Handle);
			Gst.GL.GLMemoryAllocator ret = GLib.Object.GetObject(raw_ret, true) as Gst.GL.GLMemoryAllocator;
			return ret;
		}


		static GLMemoryAllocator ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_padding"
							, Gst.GL.GLBaseMemoryAllocator.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // _padding
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
