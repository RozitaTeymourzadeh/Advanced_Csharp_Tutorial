namespace Mod03Demo01
{
    public struct Customer
    {
        private string _name;// Field (backing variable for Name Property)
        private string _email;

        public int ID { get; set; }//created using "prob+tab+tab"
        public CustomerStatusEnum Status { get; set; }
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