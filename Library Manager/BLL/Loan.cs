using System;
namespace LibraryManager.BLL
{
    public class Loan
    {
        public Loan(Item item, Member member)
        {
            this.item = item;
            this.member = member;

            borrowDate = DateTime.Today;
            dueToDate = DateTime.Today.AddDays(14);
        }

        public Item item { get; set; }
        public Member member { get; set; }
        public DateTime borrowDate { get; set; }
        public DateTime dueToDate { get; set; }


    }
}
