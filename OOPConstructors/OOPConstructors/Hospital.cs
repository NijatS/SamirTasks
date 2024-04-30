using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConstructors
{
	public class Hospital
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string Phone {  get; set; }

		public Hospital() {
            Console.WriteLine("Constructor isledi");
        }

		private void Analiz()
		{
            Console.WriteLine("Analiz Methodu isledi");
        }

		public int AnalizCavablari()
		{
			Console.Write("Ilk analiz cavabinizi daxil edin:");
			int analiz1 = int.Parse(Console.ReadLine());

			Console.Write("Ikinci analiz cavabinizi daxil edin:");
			int analiz2 = int.Parse(Console.ReadLine());

			int edediOrta = (analiz1+ analiz2)/2;
			return edediOrta;
		}

		public string GetNameAddress()
		{
			string full_ad = Name + " " + Address;
			return full_ad;
		}



		//[access modifier]   [return type]    [adi](paramertler)
		//public prive inter  void int string  Ne is gorurse ona uygun ad veririk
		//protected
	}
}
