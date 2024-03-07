using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
	internal class Person
	{
		//propertiler
		public string Name { get; set; }
		public string Surname { get; set; }


		//methodlar

		public void YemekYeme(string yediyiYemek)
		{
            Console.WriteLine(Name+" "+yediyiYemek+" yeyir");
        }
		public void Qacma()
		{
            Console.WriteLine(Name+" qacir");
        }


	}
}
