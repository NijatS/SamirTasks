using OOPTekrar;

Person person = new Person();
person.Name = "Samir";
person.Surname = "hasanli";
person.Birthday = DateOnly.Parse("08.15.1988");
person.Address = "Nizami ry";
person.PhoneNumber = "9873298587";
person.IsMarried = true;
Console.WriteLine(person.Address);


person.Address = "sebail ry";
Console.WriteLine(person.Address);



Customer customer = new Customer();
customer.Name = "Mahir";

