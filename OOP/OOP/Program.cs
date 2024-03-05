using OOP;

//instance almaq yeni classdan obyekt yaratmaq
Car yeska = new Car();
yeska.Il = 2003;
yeska.Reng = "Qirmizi";
yeska.Marka = "Mercedes";
yeska.Mator = 2.2;
yeska.Vin = "6H43JN3563J53J";

yeska.Model = "Yeclas";


Console.WriteLine("yeskanin ili " +yeska.Il);
Console.WriteLine("yeskanin rwngi" + yeska.Reng	);
Console.WriteLine(	"yeskanin matoru " +yeska.Mator);


yeska.BenzinDoldur();


yeska.MatoruDeyis();
Console.WriteLine("yeni mator " +yeska.Mator);