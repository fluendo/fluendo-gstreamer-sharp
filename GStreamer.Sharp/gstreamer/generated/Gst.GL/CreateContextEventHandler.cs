// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.GL {

	using System;

	public delegate void CreateContextEventHandler(object o, CreateContextEventArgs args);

	public class CreateContextEventArgs : GLib.SignalArgs {
		public Gst.GL.GLContext Context{
			get {
				return (Gst.GL.GLContext) Args [0];
			}
		}

	}
}
