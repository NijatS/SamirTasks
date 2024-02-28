namespace Methods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Hello();
			//Hello();
			//Hello();
			//Hello();
			//Hello();


			//Hello("samir");
			//Hello("nicat");
			Console.WriteLine("zehmet olmasa deyer girin"	);
			int a=int.Parse(Console.ReadLine());

			//int kvadrat = a * a;
			//Console.WriteLine( kvadrat );

			int cavab = kvadrati(a);
            Console.WriteLine(cavab);
            //Toplama(10,11);



            //int a1 = 15;
            //int b1 = 15;
            //Cixma(a1,b1);


            //List<int> ints = new List<int>();
            //ints.Add(1);
            //ints.Add(2);

            //int listCem = ints.Sum();
            //         Console.WriteLine();




        }


		public static void Toplama(int a , int b)
		{
			int cem = a + b;
            Console.WriteLine("Cem: " + cem);
        }

		public static void Cixma(int a , int b) {

			int cixma = a - b;
            Console.WriteLine("cixma"+cixma	);
        }

		public static void Hello()
		{
			Console.WriteLine("Salam Samir");
		}

		public static void Hello(string ad)
		{
			Console.WriteLine("Salam "+ad);
		}
		//public static void kvadrati(int a)
		//{
		//	int kvadrat = a * a;
  //          Console.WriteLine("kvadrati" + kvadrat	);
  //      }
		public static int kvadrati(int a)
		{
			int kvadrat = a * a;
			return kvadrat;
		}

	}
}
