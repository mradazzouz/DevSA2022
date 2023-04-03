using System;

namespace LibraryManager.BLL
{
    public abstract class Item
    {
        public virtual int barcode { get; set; }
        public virtual String title { get; set; }
        public virtual Loan loan { get; set; }

        public Item (String title, int barcode)
        {
            this.title = title;
            this.barcode = barcode;
            loan = null;
        }

        public bool isAvailable
        {
            get
            {
                return loan != null;
            }
        }

        public void clearLoan()
        {
            loan = null;
        }
    }
}
