namespace InterfacesSeptember.Interfaces;

//Eger qabaginda I herfi gorsen,demeli hemin file-in interfacedir.
//Daxilinde saxliya bilerik:
//Abstract methodlar sadece abstract sozu yazilmadan
//Property-ler
public interface IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }


    public void Run();//body-si olmur
    public void Eat();
    public void Sleep();
}