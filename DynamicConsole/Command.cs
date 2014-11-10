using System;
using System.Collections.Generic;
using System.Reflection;

namespace DynamicConsole
{
	public class Command
	{
		//Variable definitions
		public String Alias;
		public DyConsole.CommandDelegate Del;
		private string Info;

		public Command (string alias, DyConsole.CommandDelegate D)
		{
			Alias = alias;
			Del = D;
			Info = "No information provided";
		}

		public Command (string alias, DyConsole.CommandDelegate D, string info)
		{
			Alias = alias;
			Del = D;
			Info = info;
		}

		public string GetInfo()
		{
			return Info;
		}
	}
}

