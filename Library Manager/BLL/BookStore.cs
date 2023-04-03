using System;
using System.Collections.Generic;

namespace LibraryManager.BLL
{
    public sealed class BookStore : ItemSearch<Book>
    {
        public List<Book> books { get; set; }

        private static readonly BookStore instance = new BookStore();

        static BookStore() {
        
        }
        
        private BookStore()
        {
            books = new List<Book>();
        }

        public static BookStore Instance
        {
            get
            {
                return instance;
            }
        }

        List<Book> ItemSearch<Book>.SearchByBarcode(int barcode)
        {
            return books.FindAll(i => i.barcode == barcode);
        }

        List<Book> ItemSearch<Book>.SearchByTitle(string title)
        {
            return books.FindAll(i => i.title == title);
        }

        public List<Book> SearchBookByAuthor(string author)
        {
            return books.FindAll(i => i.author == author);
        }

        public List<Book> SearchBookByISBN(string ISBN)
        {
            return books.FindAll(i => i.ISBN == ISBN);
        }

        public void AddNewBook(String title, int barcode, String ISBN, String author)
        {
            if (!books.Exists(i => i.barcode == barcode))
            {
                Book book = new Book(title, barcode, ISBN, author);
                books.Add(book);
            }
        }

        public void RemoveBook(Book book)
        {
            if(books.Contains(book))
            {
                _ = books.Remove(book);
            }
        }
    }
}
