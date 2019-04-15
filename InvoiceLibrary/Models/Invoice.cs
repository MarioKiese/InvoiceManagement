using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceLibrary.Models
{
    class Invoice
    {

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string informationText;

        public string InformationText
        {
            get { return informationText; }
            set { informationText = value; }
        }


        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private Customer customer;

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        private List<InvoicePosition> invoicePositionList;

        public List<InvoicePosition> InvoicePositionList
        {
            get { return invoicePositionList; }
            set { invoicePositionList = value; }
        }

        private double nettoTotalAmount;

        public double NettoTotalAmount
        {
            get { return nettoTotalAmount; }
            set { nettoTotalAmount = value; }
        }

        private double bruttoTotalAmount;

        private double valueAddedTax;

        public double ValueAddedTax
        {
            get { return valueAddedTax; }
            set { valueAddedTax = value; }
        }


        public double BruttoTotalAmount
        {
            get { return bruttoTotalAmount; }
            set { bruttoTotalAmount = value; }
        }

    }
}
