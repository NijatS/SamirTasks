namespace MethodTest
{
	internal class Program
	{
		static void Main(string[] args)
		{

            //Toplama(20,30);
            Console.WriteLine("a deyerini daxil edin"	);

            int a=int.Parse(Console.ReadLine());
            Console.WriteLine(	"b deyerini daxil edin");

            int b=int.Parse(Console.ReadLine());

			int cem = Toplama(a, b);
            Console.WriteLine("Ededlerin cemi "+ cem);
           int vurma= Vurma(a, b);
            Console.WriteLine(	"ededlerin vurulmasi" +vurma);
           int cixma= Cixma(a, b);
            Console.WriteLine(	"ededlerin cixmasi"+cixma);
             float bolme=Bolme(a, b);
            Console.WriteLine(	"ededlerin bolunmesi"+ bolme);
        }


		//public static void Toplama(int a, int b)
		//{
		//	int toplam = a+ b;
		//	Console.WriteLine("ededlerin toplanmasi " +toplam);
  //      }
		public static int Toplama(int a, int b)
		{
			int toplam = a + b;
			return toplam;
		}
		//public static void Vurma(int a, int b) {

		//	int vurma = a * b;
  //          Console.WriteLine(	"ededlerin hasili " +vurma);
  //      }
		public static int Vurma(int a, int b)
		{
			int vurma = a * b;
			return vurma;
		}
		//public static void Cixma(int a,int b) {
		//	int cixma = a - b;
		//          Console.WriteLine("ededlerin cixilmasi " +cixma);
		//      }
		public static int Cixma(int a, int b)
		{
			int cixma = a - b;
			return cixma;	
		}

		//public static void Bolme(int a,int b)
		//{
		//	float bolme =(float) a / b;
		//          Console.WriteLine("ededlerin bolunmesi "+ bolme	);
		//      }
		public static float Bolme(int a, int b)
		{
			float bolme = (float)a / b;
			return bolme;	
			
		}





	}
}

