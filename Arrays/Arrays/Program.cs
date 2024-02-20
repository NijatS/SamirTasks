using System.Collections;

int[] ededler = { 1, 3, 6, 8, 4, 2, 6 };

//Yerini deyismek
ededler[4] = 10;

for (int i = 0; i < ededler.Length; i++)
{
    Console.WriteLine(ededler[i]);
}

string[] adlar = { "samir", "nicat", "ceyhun" };
//float[] ededler2 = { 2, 6 };

//for (int i = 0; i < ededler.Length; i++)
//{
//    Console.WriteLine(ededler[i]);
//}

//foreach (int eded in ededler)
//{
//    Console.WriteLine(eded);
//}

#region ArrayMethod

//Length methodu(Uzunluq)
//Console.WriteLine(ededler.Length);

//Indexe gore cagirma
//Console.WriteLine(ededler[5]);

// Sort Methodu (azdan coxa ve ya elifba sirasi ile)
//Array.Sort(ededler);
//for (int i = 0; i < ededler.Length; i++)
//{
//	Console.WriteLine(ededler[i]);
//}


//Array.Sort(adlar);
//string[] adlar = { "ceyhun", "nicat","samir" };
//foreach (string ad in adlar)
//{
//	Console.WriteLine(ad);
//}



// Reverse Methodu Tersi(Guzgu eksi)

//Array.Reverse(ededler);

//for (int i = 0; i < ededler.Length; i++)
//{
//    Console.WriteLine(ededler[i]);
//}

//Array.Reverse(adlar);

//foreach(string ad in adlar)
//{
//    Console.WriteLine(ad);
//}


// IndexOf  Verilen ededin yerini tapir yeniki indexini
//Console.WriteLine(Array.IndexOf(ededler, 6));


//Clear Methodu
//string[] dersler = new string[5];

//dersler[0] = "Html";
//dersler[1] = "Azkod";
//dersler[2] = "Azkod.com";
//dersler[3] = "Css";
//dersler[4] = "JavaScript";

//Console.WriteLine("Silinmezden evvel");
//foreach (string yaz in dersler)
//{

//	Console.WriteLine(yaz);

//}

//Array.Clear(dersler, 1, 2);
//Console.WriteLine("\n\n\nSilinmezden sonra");

//foreach (string yaz in dersler)
//{
//	Console.WriteLine(yaz);
//}


#endregion