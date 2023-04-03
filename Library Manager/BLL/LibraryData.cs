using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.BLL
{
    public class LibraryData
    {
        public LibraryData()
        {
        }

        public LibraryData(List<Member> members, List<DVD> dVDs, List<Book> books)
        {
            Members = members;
            DVDs = dVDs;
            Books = books;
        }

        public List<Member> Members { get; set; }
        public List<DVD> DVDs { get; set; }

        public List<Book> Books { get; set; }
    }
}
