using Inheritance;

Isci isci = new Isci();
isci.Name = "Nijat";
isci.Maas = 3123.6;


Alici alici = new Alici();
alici.Name = "Samir";
alici.AldigiMallar = "Telefon";


//Obyekt yarada bilirik
//Abstract classdan obyekt yaratmaq olmur
//Person person = new Person();


string name = "Nijat";
var name2 =name.Clone();

isci.Satma("banan");
isci.Satma("alma");
//Console.WriteLine(name2);