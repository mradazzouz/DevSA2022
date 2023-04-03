using System;
using System.Collections.Generic;

namespace LibraryManager.BLL
{
    public class LoanStore
    {
        public List<Loan> loans { get; set; }

        private static readonly LoanStore instance = new LoanStore();

        static LoanStore()
        {

        }

        private LoanStore()
        {
            loans = new List<Loan>();
        }

        public static LoanStore Instance
        {
            get
            {
                return instance;
            }
        }

        public void CreateNewLoan(Member member, Item item)
        {
            if(!loans.Exists(i => i.item == item && i.member == member))
            {
                Loan loan = new Loan(item, member);
                loans.Add(loan);
            }
        }

        public void CloseLoan(Loan loan)
        {
            loan.item.clearLoan();

            if (loans.Contains(loan))
            {
                _ = loans.Remove(loan);
            }
        }

        public List<Loan> GetLoansForMember(Member menber)
        {
            return loans.FindAll(i => i.member == menber);
        }

        public void CreatePaymentRequest(Member member, Loan loan)
        {
            double expiredDays = (DateTime.Today - loan.dueToDate).TotalDays;

            if (expiredDays > 0)
            {
                PaymentRequest request = new PaymentRequest(Convert.ToInt32(expiredDays) * 10);
                member.AssignPaymentRequest(request);
            }
        }
    }
}
