using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal class Person
	{
        //field
        //public string Name; 
        //property
        public string Ad { get; set; }    
        private string Name { get; set; } 
        protected string NesilMelumatlari { get; set; }
        public string Soyad { get; set; }
        public string Address { get; set; }
        public string TelefonNomresi { get; set; }
        public int Yas { get; set; }
        public DateTime DogumTarixi { get; set; }
    }
}
