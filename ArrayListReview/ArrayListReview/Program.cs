using System.Collections;

namespace ArrayListReview
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//int[] ededler = { 1, 2, 7, 4, 5 };

			//ededler[5] = 11;


			//for (int i = 0; i < ededler.Length; i++)
			//{
			//	Console.WriteLine(ededler[i]);
			//}


			ArrayList arrayList = new ArrayList();
			arrayList.Add(1);
			arrayList.Add(12);
			arrayList.Add(3);
			arrayList.Add(-4);

			//for (int i = 0; i < arrayList.Count; i++) {
			//	Console.WriteLine(arrayList[i]);
			//         }
			Console.WriteLine("------------------------");
			arrayList.Add(101);
			arrayList.Add("Samir");//Sonuna elave eliyir
			arrayList.Insert(2, "Nijat");//Verdiyimiz indexe elave edir

			arrayList.Remove("Samir");//Verdiyimi deyeri silir
			arrayList.RemoveAt(2);//Verdiyimiz indexe uygun silir

			arrayList.Sort();

			//for (int i = 0; i < arrayList.Count; i++)
			//{
			//	Console.WriteLine(arrayList[i]);
			//}


			List<int> ededler = new List<int>();
			ededler.Add(1);
			ededler.Add(2);
			ededler.Add(3);
			//ededler.Add("Samir");//Compile Time Error

			foreach (int eded in ededler)
			{
				Console.WriteLine(eded);
			}

			List<string> adlar = new List<string>();
			adlar.Add("Samir");
			adlar.Add("Nijat");
			adlar.Add("Test");

			Console.WriteLine("----------------------------");
			adlar.Sort();//Elifba sirasi ile cixarir
			adlar.Reverse(); // Verilen listin tersine cixarir

			foreach (string ad in adlar)
			{
				Console.WriteLine(ad);
			}
			int a = 1;
			int b = 10;
			//For
			//for (int i = a; i <= b; i++)
			//{
			//             Console.WriteLine(i);
			//}

			//While
			int i = a;
			//while (i<=b)
			//{
			//             Console.WriteLine(i);
			//	i++;
			//         }

			//DoWhile
			do
			{
				Console.WriteLine(i);
				i++;
			}
			while (i <= b);


		}
	}
}
