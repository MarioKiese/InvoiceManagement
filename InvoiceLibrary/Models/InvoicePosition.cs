namespace InvoiceLibrary.Models
{
    class InvoicePosition
    {

        private string article;

        public string Arcticle
        {
            get { return article; }
            set { article = value; }
        }
        private string descriptionText;

        public string DescriptionText
        {
            get { return descriptionText; }
            set { descriptionText = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private double pricePerUnit;

        public double PricePerUnit
        {
            get { return pricePerUnit; }
            set { pricePerUnit = value; }
        }

        private double valueAddedTax;

        public double ValueAddedTax
        {
            get { return valueAddedTax; }
            set { valueAddedTax = value; }
        }

        private double nettoTotalPrice;

        public double NettoTotalPrice
        {
            get { return nettoTotalPrice; }
            set { nettoTotalPrice = value; }
        }

        private double bruttoTotalPrice;

        public double BruttoTotalPrice
        {
            get { return bruttoTotalPrice; }
            set { bruttoTotalPrice = value; }
        }

    }
}