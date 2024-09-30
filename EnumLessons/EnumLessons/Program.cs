using EnumLessons.Enums;

namespace EnumLessons;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Heftenin gununu qeyd edin(reqemle):");
        // int hefteGunu = int.Parse(Console.ReadLine());
        //
        // if (hefteGunu == 1)
        // {
        //     Console.WriteLine(WeekDay.Monday);
        // }
        // else if (hefteGunu == 2)
        // {
        //     Console.WriteLine(WeekDay.Tuesday);
        // }
        // else if (hefteGunu == 3)
        // {
        //     Console.WriteLine(WeekDay.Wednesday);
        // }


        // string name = Enum.GetName(typeof(WeekDay), 5);
        //
        // Console.WriteLine(name);

        // string[] names =  Enum.GetNames(typeof(WeekDay));
        //
        // foreach (var name in names)
        // {
        //     Console.WriteLine(name);
        // }
        
        var values = Enum.GetValues(typeof(WeekDay));

        foreach (var value in values)
        {
            Console.WriteLine((int)value);
        }



    }
}