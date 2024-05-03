namespace Encapsulation
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Car car  = new Car();
			car.SetName("F10");


            Console.WriteLine(car.GetName());
        }
	}
}
