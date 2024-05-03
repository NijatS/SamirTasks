namespace Constructors
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person person1 = new Person();
			person1.Name = "Test";

			Person person2 = new Person(1,"Samir","Hasanli","Neftciler");
		}
	}
}
