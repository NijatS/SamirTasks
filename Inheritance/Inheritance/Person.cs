using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Address { get; set; }

		public void Eating()
		{
            Console.WriteLine("Insan yemek yeyir");
        }
	}
}
