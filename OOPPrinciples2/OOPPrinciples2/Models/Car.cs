namespace OOPPrinciples2.Models;


//Abstraction c# 2 usulla yarada bilerik:
//1.Abstract classlar ile
// Abstact class-in daxilinde bir nece nov method yaza bilerik.Amma bu ikisi daha cox
// goze carpir
 
   //1.1 Abstract method
   //1.2 Virtual method 


//2.Interfaces ile 
public abstract class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
}