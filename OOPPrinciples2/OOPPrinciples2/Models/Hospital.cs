namespace OOPPrinciples2.Models;

public class Hospital
{
    //private field
    private int _id;
    private string _name;
    private string _address;
    private string _email;
    private string _phone;
    private int _createdDate;
    
    //public property
    //set- Menimsedme prosesini yerine yetirir
    //get- datani qaytarmaq ucun islenir
    //Encapsulation
    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            //yoxlanis merhelesi
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Adin bos ola bilmez");
            }
            //menimsetme islemi
            _name = value;
        }
    }

    public string Address
    {
        get
        {
            return _address;
        }
        set
        {
            _address = value;
        }
    }

    public string Phone
    {
        get
        {
            return _phone;
        }
        set
        {
            _phone = value;
        }
    }

    public string Email
    {
        get
        {
            return _email;
        }
        set
        {
            _email = value;
        }
    }

    public int CreatedDate
    {
        get
        {
            return _createdDate;
        }
        set
        {
            if (_createdDate > 2024)
            {
                throw new Exception("Ili duzgun daxil edin");
            }
            
            _createdDate = value;
        }
    }

}