using System;
namespace LibraryManager.BLL
{
    public class DVD : Item
    {
        public String director { get; set; }

        public DVD(String title, int barcode, String director) : base(title, barcode)
        {
            this.director = director;
        }
    }
}
