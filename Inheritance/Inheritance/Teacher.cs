using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	//Teach
	internal class Teacher :Person  // Teacher is Person, Muellim bir insandir
	{
		public double Salary { get; set; }
	
		private void Teaching()
		{
            Console.WriteLine("Muellim ders deyir");
        }
		//public void Eating()
		//{
		//	Console.WriteLine("Muellim yemek yeyir");
		//}
	}
}
