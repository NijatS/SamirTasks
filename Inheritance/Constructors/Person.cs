using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
	internal class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Address { get; set; }
		public DateTime SistemeDaxilOlma { get; set; }

		//Classdan obyekt yaradan anda ise dusur.
		//Classin adi ile eyni olur. Type qaytarmiyan methoddur.
		public Person()
		{
			SistemeDaxilOlma = DateTime.Now;
			Console.WriteLine("Constructors ise dusdu");
		}
		//Dolu constructor
		public Person(int Id, string Name, string Surname, string Address)
		{
			this.Id = Id;
			this.Name = Name;
			this.Surname = Surname;
			this.Address = Address;
		}
		//1ce defe ise dusur.
		static Person()
		{
			Console.WriteLine("Static constuctors");
		}
	}
}
