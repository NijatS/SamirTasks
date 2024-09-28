namespace Polymorpishm;

public abstract class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public abstract void Gezmek();
}