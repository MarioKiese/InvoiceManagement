namespace InvoiceLibrary.Models
{
    class Customer
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Address address;

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }


    }
}