using System;

namespace ArrayReview
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//string name = "Samir";
			string name2 = "Nijat";
			string name3 = "Ali";

			string[] names = { "Samir", "Nijat", "Ali","Samir2" };
            //string[] names2 = new string[3];
            //names2[0] = "Samir";
            //names2[1] = "Nijat";
            //names2[2] = "Ali";


            //Console.WriteLine(names[1]);

            //for (int i = 0; i < names.Length; i++)
            //{
            //	Console.WriteLine(names[i]);
            //}
            ////Console.WriteLine(names[2]);

            //foreach (string name in names)
            //{
            //	Console.WriteLine(name);
            //}

            //Length
            //Clear
            //Reverse
            //Sort
            //İndexOf

            //Console.WriteLine(names.Length);
            //int index =Array.IndexOf(names, "Samir3");
            //Console.WriteLine(index);


            //Sort
            Console.WriteLine("Sort olmamisdan evvel");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Sort olduqdan sonra");
            Array.Sort(names);
			foreach (string name in names)
			{
				Console.WriteLine(name);
			}
			Console.WriteLine("-----------------------------");

			Console.WriteLine("Reverse olduqdan sonra");
			Array.Reverse(names);
			foreach (string name in names)
			{
				Console.WriteLine(name);
			}

		}
	}
}
