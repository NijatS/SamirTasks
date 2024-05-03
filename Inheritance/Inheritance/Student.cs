using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal class Student :Person
	{
		public string University { get; set; }
		public void GoUniversity()
		{
			Console.WriteLine("Telebe universitete gedir");
		}
	}
}
