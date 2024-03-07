using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTekrar
{
	//Ata class
	internal class Person
	{
		//property ler
        public string Name { get; set; }
		public string Surname { get; set; }
		public DateOnly	Birthday { get; set; }	
		public string Address { get; set; }
		public string PhoneNumber { get; set; }
		public bool IsMarried { get; set; }	

    }
}
