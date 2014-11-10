using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace DynamicConsole
{
	public class DyConsole
	{
		//Declare Variables
		private List<Command> CommandList;
		private List<Variable> VariableList;
		public delegate void CommandDelegate (List<Object> args);
		public Type MainType;
		ConsoleWindow Window;

		public DyConsole ()
		{
			//Initialise variables
			CommandList = new List<Command>();
			VariableList = new List<Variable> ();
			Gtk.Application.Init ();
			Window = new ConsoleWindow (this);
			Window.Show ();
			MainType = Type.GetType ("Main");
		}

		public void Open()
		{
			Gtk.Application.Run();
		}

		public void Close()
		{
			Gtk.Application.Quit ();
		}

		public void AddCommand(Command C)
		{
			CommandList.Add (C);
		}

		public void AddVariable(Variable V)
		{
			VariableList.Add (V);
		}

		public void ExecCommand(string args)
		{
			string[] SplitArgs;
			SplitArgs = args.Split (' ');
			List<Object> FinalArgs = new List<Object>();
			List<Object> DelegateArgs = new List<Object> ();

			for(int I = 0; I < SplitArgs.Length;I++)
			{
				for (int J = 0; J < VariableList.Count; J++)
				{
					if (SplitArgs [I] == VariableList [J].Alias)
					{
						FinalArgs.Add (VariableList [J]);
						DelegateArgs.Add (VariableList [J].Value);
					}
				}

				if (FinalArgs.Count != I + 1)
				{
					FinalArgs.Add (SplitArgs [I]);
					DelegateArgs.Add (SplitArgs [I]);
				}
			}
		

			for (int I = 0; I < CommandList.Count; I++)
			{
				if (FinalArgs[0].ToString() == CommandList [I].Alias)
				{
					FinalArgs.Remove (FinalArgs [0]);
					DelegateArgs.Remove(DelegateArgs[0]);
					CommandList [I].Del(DelegateArgs);
					Window.OutputWrite ("Executing " + CommandList [I].Alias + "\nArguments:");
				}
			}

			foreach (Object O in FinalArgs)
			{
				try
				{
					Window.OutputWrite((O as Variable).Alias + ": " + (O as Variable).Value.ToString());
				}
				catch (NullReferenceException)
				{
					Window.OutputWrite (O.ToString());
				}
			}
			Window.OutputWrite ("");
		}
	}
}

