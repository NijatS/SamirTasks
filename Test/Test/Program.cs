namespace Test
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//int[] ededler = {-5,2,6,-6,7,8,-9,11,20};
			//int musbetSay = 0;
			//int menfiSay = 0;

			//for (int i = 0; i < ededler.Length; i++)
			//{
			//	if (ededler[i] > 0)
			//	{
			//		musbetSay++;
			//	}
			//	else
			//	{
			//		menfiSay++;
			//	}
			//}
			//         Console.WriteLine("Musbet say:" + musbetSay);
			//Console.WriteLine("Menfi say:" + menfiSay);


			//              ededler[0]  ededler[1]                   ededler[5]
			//int[] ededler = {  -5   ,       32    ,    -23, 41, 55,      62    };
			//int cem = 0;


			//for (int i = 0; i < ededler.Length; i++)
			//{
			//	cem += ededler[i];
			//}
			//Console.WriteLine("Cem:" + cem);




			int[] ededler = { 1, 11, 51, 5, -8, 32, 62, -15, 44 };
			int min = ededler[0];

			for (int i = 1; i < ededler.Length; i++)
			{
				if (ededler[i] < min)
				{
					min = ededler[i];
				}
			}
            Console.WriteLine("Min:" + min);


        }
	}
}
