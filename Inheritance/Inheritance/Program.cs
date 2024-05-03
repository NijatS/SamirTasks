namespace Inheritance
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Person person = new Person();
			person.Eating();

			Teacher teacher = new Teacher();
			teacher.Eating();
			//teacher.Teaching();

			Student student = new Student();
			student.Eating();
			student.GoUniversity();
		}
	}
}
