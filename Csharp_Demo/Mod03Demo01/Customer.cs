namespace Mod03Demo01
{
    public struct Customer
    {
    private string _name;// Field (backing variable for Name Property)
    private string _email;
    private int _id;
    private CustomerStatusEnum _status;

    //public int ID { get; set; }//created using "prob+tab+tab"
    //public CustomerStatusEnum Status { get; set; }
    public string Name // Property
    {
        get
        {
            return _name;
        }

        set
        {
            //validation
            _name = value;
        }
    }
    public string Email // can be built using Encapsulate way. right click on _email Select "Refactor", Selec Encapsulate Field from _email to Email
    {
        get
        {
            return _email;
        }

        set
        {
            //validation
            _email = value;
        }
    }
    public int ID
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
    public CustomerStatusEnum Status
    {
        get
        {
            return _status;
        }

        set
        {
            _status = value;
        }
    }

    public Customer(int ID, string Name, CustomerStatusEnum Status, string Email)// Constructor
    {
        _name = Name;
        _email = Email;
        _id = ID;
        _status = Status;
    }

    public string Details()
    {
        return string.Format("{0}\n{1}\n{2}\n{3}", ID,Name,Status,Email);
    }
    }
    public enum CustomerStatusEnum
    {
        Silver,
        Gold,
        Platinum
    }
}