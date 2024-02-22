#region HomeTask
//int[] reqemler = { 1, 4, 3, 6, 5, 9 };
//Array.Sort(reqemler);
//for (int i = 0; i <reqemler.Length; i++)
//{
//	Console.WriteLine(reqemler[i]);	
//}	

//Array.Reverse(reqemler);	
//foreach (int reqem in reqemler)
//{
//	Console.WriteLine(reqem);
//}
//int index=Array.IndexOf(reqemler, 6);
//Console.WriteLine("6 reqeminin yeri "+index);


//int i = reqemler.Length;
//Console.WriteLine("uzunlugu"+i	);
#endregion

#region ArrayList

//using System.Collections;

//ArrayList ededler = new ArrayList() ;


//ededler.Add(5);
//ededler.Add(6);
//ededler.Add(67);
//ededler.Add(17);
//ededler.Add(16);
//ededler.Add("samir");
//ededler.Add(5.4);

//ededler.Insert(5, "nijat");


//ededler.Remove("samir");


//ededler.RemoveAt(5);
//ededler.Sort();
//ededler.Reverse();
//foreach (var eded in ededler)
//{
//    Console.WriteLine(eded);
//}


#endregion

#region List
using System.Collections;

ArrayList adlar1 = new ArrayList();
List<string> adlar2 = new List<string>();

adlar2.Add("nijat");
adlar2.Add("samir");

foreach (string ad in adlar2)
{
    Console.WriteLine(ad);
}


List<int> regemler = new List<int>();
regemler.Add(5);
regemler.Add(6);

Console.WriteLine(regemler.Count());

#endregion