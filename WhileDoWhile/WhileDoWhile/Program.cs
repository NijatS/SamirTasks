namespace WhileDoWhile
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//int i = 0;
			//while(i > 10)
			//{
			//             Console.WriteLine(i);
			//	i++;
			//         }
			//         Console.WriteLine("\n------------------------------------\n");

			//         int j = 0;
			//do
			//{
			//	Console.WriteLine(j);
			//	j++;
			//}
			//while (j > 10);


			bool DavamEtsinmi = true;
			do
			{
				Console.WriteLine("Eded daxil edin:");
				int eded = int.Parse(Console.ReadLine());

				if (eded % 3 == 0 && eded % 5 == 0)
				{
                    Console.WriteLine(eded);
					DavamEtsinmi = false;
                }
            }
			while (DavamEtsinmi);




        }
	}
}
