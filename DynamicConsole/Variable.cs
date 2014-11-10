using System;
using System.Reflection;

namespace DynamicConsole
{
	public class Variable
	{
		//Variable definitions
		public string Alias;
		public Object Value;

		public Variable (String alias, Object value)
		{
			Alias = alias;
			Value = value;
		}

		public string GetInfo()
		{
			return Value.ToString ();
		}
	}
}

