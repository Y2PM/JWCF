using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFDemo
{
    public class BookService : IBookService
    {
        //Book book = new Book() { name = "NameOfBookHere", numberOfPages =5};

        //private List<Book> _books;

        private List<Book> _books = new List<Book>()
        {
            new Book { name = "Abel Shmabelend"}
        };

        //_books.Add(book);
        
        public List<Book> GetBooks()
        {
            return _books;
        }

        //public void ChangeNumberOfPagesInBook(Book book)
        //{
        //    _books.Find(b => b.name == book.name).numberOfPages++;
        //}
    }
}
