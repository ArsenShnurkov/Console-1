using System;
using Gtk;

namespace DynamicConsole
{
	public partial class ConsoleWindow : Gtk.Window
	{
		//Declare Variables
		DyConsole Owner;

		public ConsoleWindow (DyConsole owner) : 
				base(Gtk.WindowType.Toplevel)
		{
			Owner = owner;
			this.Build ();
		}

		protected void OnWindowKeyPress (object o, Gtk.KeyPressEventArgs args)
		{
			if (args.Event.Key == Gdk.Key.Escape) 
			{
				Application.Quit ();
			}
		}

		public void OutputWrite (string S)
		{
			System.Text.StringBuilder SB = new System.Text.StringBuilder (OutputBox.Buffer.Text);
			SB.Append (S);
			SB.Append ("\n");
			OutputBox.Buffer.Text = SB.ToString ();
		}

		protected void OnTextInput (object sender, EventArgs e)
		{
			Owner.ExecCommand (InputBox.Text);
			InputBox.Text = "";
		}
	}
}

