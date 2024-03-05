using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class Car
	{
		public int Il {  get; set; }
		public string Reng { get; set; }	
		public string Model { get; set; }
		public  double  Mator{ get; set; }	
	    public string Marka {  get; set; }	
		public string Vin { get; set; }
		//Constructor
        public Car()
        {
        }
		//Methodlarda yazmaq olur
		public void BenzinDoldur()
		{
            Console.WriteLine("Masin benzin dolduruldu");
        }
		public void MatoruDeyis()
		{
            Console.WriteLine("matoru neye deyismek isdiyirsiz");
			double yeniMator=double.Parse(Console.ReadLine());	
			Mator = yeniMator;
        }


    }


}
