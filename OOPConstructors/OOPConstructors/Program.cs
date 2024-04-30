namespace OOPConstructors
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Hospital hospital1 = new Hospital();
			hospital1.Id = 1;
			hospital1.Name = "Medical";
			hospital1.Address = "Babek";
			hospital1.Phone = "1248421";

			Hospital hospital2 = new Hospital();
			hospital2.Id = 2;
			hospital2.Name = "Medical";
			hospital2.Address = "28 May";
			hospital2.Phone = "232425";

			//Console.WriteLine(hospital1.Name);


			hospital1.Analiz();
			//int cavab = hospital1.AnalizCavablari();
			//Console.WriteLine(cavab);

			Console.WriteLine(hospital1.GetNameAddress());
			Console.WriteLine(hospital2.GetNameAddress());
		}
	}
}
