namespace InvoiceLibrary.Models
{
    class Address
    {
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string zipCode;

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        private string street;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}