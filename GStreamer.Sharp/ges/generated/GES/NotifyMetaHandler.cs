// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GES {

	using System;

	public delegate void NotifyMetaHandler(object o, NotifyMetaArgs args);

	public class NotifyMetaArgs : GLib.SignalArgs {
		public string Key{
			get {
				return (string) Args [0];
			}
		}

		public GLib.Value Value{
			get {
				return (GLib.Value) Args [1];
			}
		}

	}
}
