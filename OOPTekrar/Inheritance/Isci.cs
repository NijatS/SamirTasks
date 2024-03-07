using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal class Isci :Person
	{
		public double Maas { get; set; }
		public void Satma(string satdigimal)
		{
            Console.WriteLine(Name+" bugun "+satdigimal+" satmisdir");
        }
	}
}
