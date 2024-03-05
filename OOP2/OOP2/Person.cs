using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
	internal class Person
	{
		//propertyler bizim dilde xususiyyetleri
		public string Name { get; set; }
		public string SurName { get; set; }
		public DateOnly Birthday { get; set; }
		public string PhoneNumber {  get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public int CityCode { get; set; }	

		//methodlar yeni funksiyalar

		public void AdinCapi()
		{
            Console.WriteLine(Name);
        }

        //constructorlar

        public Person()
        {
            Console.WriteLine("Constractor ise dusdu");
            Console.WriteLine("Samir");
        }
        //public Person(string Name)
        //{
            
        //}
    }
}
