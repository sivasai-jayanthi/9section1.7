using System;
using System.Collections.Generic;
using System.Text;

namespace _9section1._7
{
	public class Teacher
	{
		private string name;
		private string address;
		private string contactAddress;
		private DateTime dateOfJoining;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public string ContactAddress
		{
			get { return address; }
			set { address = value; }
		}

		public DateTime DateOfJoining
		{
			get { return dateOfJoining; }
			set { dateOfJoining = value; }
		}
	}
}
