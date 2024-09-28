namespace Polymorpishm.InterfaceLesson;

//Interface classdan ferqi oduki, Iterface-in daxiline yalniz ve yalniz abstract method ve property yazilir
public interface ICar
{
    //abstract method
    public void HereketEtmek();
    public void BenzinVurmaq();
    
    //property
    public double Motor { get; set; }
    public double Qiymet{ get; set; }
}