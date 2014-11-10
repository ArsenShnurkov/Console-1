using System;
using DynamicConsole;
using System.Collections.Generic;

namespace Test
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			DyConsole DConsole = new DyConsole ();

			int X = 36;
			DConsole.AddVariable(new Variable("X",X));
			int Y = 7;
			DConsole.AddVariable (new Variable ("Y", Y));
			DConsole.AddCommand(new Command("Foo",new DyConsole.CommandDelegate(Foo)));

			DConsole.Open ();

		}

		public static void Foo (List<Object> args)
		{
			foreach (Object O in args) 
			{
				Console.WriteLine (O.ToString ());
			}
		}
	}
}
