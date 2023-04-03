using System;
namespace LibraryManager.BLL
{
    public class Book : Item
    {
        public String author { get; set; }
        public String ISBN { get; set; }

        public Book(String title, int barcode, String ISBN, String author):base(title,barcode)
        {
            this.ISBN = ISBN;
            this.author = author;
        }
    }
}
