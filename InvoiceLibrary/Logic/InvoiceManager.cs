using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceLibrary.Models;

namespace InvoiceLibrary.Logic
{
    class InvoiceManager
    {
        public InvoiceManager()
        {
            LoadInvoiceLayout();
            LoadUserInformation();
        }

        #region Properties

        private InvoiceLayout invoiceLayout;

        public InvoiceLayout InvoiceLayout
        {
            set { invoiceLayout = value; }
        }

        private UserInformation userInformation;

        public UserInformation UserInformation
        {
            set { userInformation = value; }
        }


        #endregion

        #region Public Methods

        public Invoice CreateInvoice()
        {
            return new Invoice();
        }

        public void CreatePdf(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public void PrintInvoice(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Methods

        private void LoadInvoiceLayout()
        {
            throw new NotImplementedException();
        }

        private void LoadUserInformation()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
