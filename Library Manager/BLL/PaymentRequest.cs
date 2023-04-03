using System;
namespace LibraryManager.BLL
{
    public class PaymentRequest
    {
        public PaymentRequest(int amount)
        {
            this.amount = amount;
            this.dueToDate = DateTime.Today.AddDays(8);
        }

        public int amount { get; set; }
        public DateTime dueToDate { get; set; }
    }
}
