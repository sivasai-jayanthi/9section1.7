using System;
using System.Collections.Generic;
using System.Text;

namespace _9section1._7
{
	public class Subject
	{
		private string name;
		private string shortName;

		public string Name
		{
			get { return name; }
			set { this.name = value; }
		}

		public string ShortName
		{
			get { return shortName; }
			set { shortName = value; }
		}
	}
}
