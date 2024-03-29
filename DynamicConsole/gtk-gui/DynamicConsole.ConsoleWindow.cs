
// This file has been generated by the GUI designer. Do not modify.
namespace DynamicConsole
{
	public partial class ConsoleWindow
	{
		private global::Gtk.VBox vbox3;
		private global::Gtk.TextView OutputBox;
		private global::Gtk.HSeparator hseparator2;
		private global::Gtk.Entry InputBox;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget DynamicConsole.ConsoleWindow
			this.Name = "DynamicConsole.ConsoleWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("ConsoleWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child DynamicConsole.ConsoleWindow.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.OutputBox = new global::Gtk.TextView ();
			this.OutputBox.CanFocus = true;
			this.OutputBox.Name = "OutputBox";
			this.OutputBox.Editable = false;
			this.OutputBox.CursorVisible = false;
			this.OutputBox.WrapMode = ((global::Gtk.WrapMode)(2));
			this.vbox3.Add (this.OutputBox);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.OutputBox]));
			w1.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator ();
			this.hseparator2.Name = "hseparator2";
			this.vbox3.Add (this.hseparator2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hseparator2]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.InputBox = new global::Gtk.Entry ();
			this.InputBox.CanFocus = true;
			this.InputBox.Name = "InputBox";
			this.InputBox.IsEditable = true;
			this.InputBox.ActivatesDefault = true;
			this.InputBox.InvisibleChar = '●';
			this.vbox3.Add (this.InputBox);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.InputBox]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			w3.Padding = ((uint)(8));
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 483;
			this.DefaultHeight = 300;
			this.Show ();
			this.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnWindowKeyPress);
			this.InputBox.Activated += new global::System.EventHandler (this.OnTextInput);
		}
	}
}
