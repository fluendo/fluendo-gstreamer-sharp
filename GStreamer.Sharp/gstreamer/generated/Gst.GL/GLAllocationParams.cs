// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GL {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct GLAllocationParams : IEquatable<GLAllocationParams> {

		private UIntPtr struct_size;
		public ulong StructSize {
			get {
				return (ulong) struct_size;
			}
			set {
				struct_size = new UIntPtr (value);
			}
		}
		private Gst.GLSharp.GLAllocationParamsCopyFuncNative _copy;
		public Gst.GL.GLAllocationParamsCopyFunc CopyFunc {
			get {
				return Gst.GLSharp.GLAllocationParamsCopyFuncWrapper.GetManagedDelegate (_copy);
			}
		}
		private Gst.GLSharp.GLAllocationParamsFreeFuncNative _free;
		public Gst.GL.GLAllocationParamsFreeFunc FreeFunc {
			get {
				return Gst.GLSharp.GLAllocationParamsFreeFuncWrapper.GetManagedDelegate (_free);
			}
		}
		public uint AllocFlags;
		private UIntPtr alloc_size;
		public ulong AllocSize {
			get {
				return (ulong) alloc_size;
			}
			set {
				alloc_size = new UIntPtr (value);
			}
		}
		private IntPtr _alloc_params;

		public Gst.AllocationParams alloc_params {
			get { return Gst.AllocationParams.New (_alloc_params); }
		}
		private IntPtr _context;
		public Gst.GL.GLContext Context {
			get {
				return GLib.Object.GetObject(_context) as Gst.GL.GLContext;
			}
			set {
				_context = value == null ? IntPtr.Zero : value.Handle;
			}
		}
		public GLib.DestroyNotify Notify;
		private IntPtr _user_data;
		private IntPtr _wrapped_data;
		private IntPtr _gl_handle;
		[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
		private IntPtr[] _Padding;

		public static Gst.GL.GLAllocationParams Zero = new Gst.GL.GLAllocationParams ();

		public static Gst.GL.GLAllocationParams New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.GL.GLAllocationParams.Zero;
			return (Gst.GL.GLAllocationParams) Marshal.PtrToStructure (raw, typeof (Gst.GL.GLAllocationParams));
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_gl_allocation_params_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_gl_allocation_params_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_allocation_params_copy_data(IntPtr raw, IntPtr dest);

		public void CopyData(Gst.GL.GLAllocationParams dest) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_dest = GLib.Marshaller.StructureToPtrAlloc (dest);
			gst_gl_allocation_params_copy_data(this_as_native, native_dest);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_dest);
		}

		[DllImport("gstgl-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_gl_allocation_params_free_data(IntPtr raw);

		public void FreeData() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gst_gl_allocation_params_free_data(this_as_native);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		static void ReadNative (IntPtr native, ref Gst.GL.GLAllocationParams target)
		{
			target = New (native);
		}

		public bool Equals (GLAllocationParams other)
		{
			return true && StructSize.Equals (other.StructSize) && CopyFunc.Equals (other.CopyFunc) && FreeFunc.Equals (other.FreeFunc) && AllocFlags.Equals (other.AllocFlags) && AllocSize.Equals (other.AllocSize) && alloc_params.Equals (other.alloc_params) && Context.Equals (other.Context) && Notify.Equals (other.Notify) && _user_data.Equals (other._user_data) && _wrapped_data.Equals (other._wrapped_data) && _gl_handle.Equals (other._gl_handle);
		}

		public override bool Equals (object other)
		{
			return other is GLAllocationParams && Equals ((GLAllocationParams) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ StructSize.GetHashCode () ^ CopyFunc.GetHashCode () ^ FreeFunc.GetHashCode () ^ AllocFlags.GetHashCode () ^ AllocSize.GetHashCode () ^ alloc_params.GetHashCode () ^ Context.GetHashCode () ^ Notify.GetHashCode () ^ _user_data.GetHashCode () ^ _wrapped_data.GetHashCode () ^ _gl_handle.GetHashCode ();
		}

		public static explicit operator GLib.Value (Gst.GL.GLAllocationParams boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Gst.GL.GLAllocationParams.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Gst.GL.GLAllocationParams (GLib.Value val)
		{
			return (Gst.GL.GLAllocationParams) val.Val;
		}
#endregion
	}
}
