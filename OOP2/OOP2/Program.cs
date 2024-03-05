#region Person OOP

using OOP2;

Person person1 = new Person();

person1.Name = "Samir";
person1.SurName = "Hasanli";
person1.Birthday = DateOnly.Parse("08/15/1988");
person1.PhoneNumber = "0502995004";
person1.Email = "person1hasanlih@gmail.com";
person1.Address = "Nizami ry";
person1.CityCode = 10;



//Console.WriteLine(person1.PhoneNumber	);



Person person2 = new Person();
person2.Name = "Mahir";
person2.CityCode = 99;
//Console.WriteLine("Samirin seriya nomresi " + person1.CityCode);
//Console.WriteLine(person1.Name+"in seriya nomresi "+person1.CityCode);
//Console.WriteLine(person1.CityCode);


//person1.Name = "Nicat";
//Console.WriteLine(person1.Name + "in seriya nomresi " + person1.CityCode);


//person1.Name = "Samir";
//Console.WriteLine(person1.Name + "in seriya nomresi " + person1.CityCode);



//person1.Name = "Qasim";
//Console.WriteLine(person1.Name + "in seriya nomresi " + person1.CityCode);


//Console.WriteLine(person1.SurName);

//person1.SurName = "Elizade";
//Console.WriteLine(person1.SurName);
//person1.SurName = "Quluzade";
//Console.WriteLine(person1.SurName);

//person1.AdinCapi();
//person2.AdinCapi();
#endregion


#region Hospital 

Hospital hospital1 = new Hospital(); 
//hospital1.in adi baku medical plazadir
// in -> .
// dir -> =
hospital1.Name = "BMP";
hospital1.Address = "Babek pr";
hospital1.Rating = 4.5;
hospital1.Sector = "Ozel";
hospital1.PhoneNumber = "093403945034";
hospital1.IsService = true;



Console.WriteLine(hospital1.Name+ " " + hospital1.Address);




#endregion