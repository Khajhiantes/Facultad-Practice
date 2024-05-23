using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System_OOP_
{
    internal class Library
    {
        List<Ibook> books = new List<Ibook>();
        public void AddBook(Ibook book)
        {
            books.Add(book);
            Console.WriteLine($"Adding {book.Title} by {book.Author}");
        }

        public void ReadBook( string title)
        {
            // I found it easier to use the FirstOrDefault() method to find a book by its title.
            // However, if there is no book with the given title, FirstOrDefault() returns null.
            var book = books.FirstOrDefault(b => b.Title == title);
            if (book != null)
            {
                book.Read();
            }
            else
            {
                Console.WriteLine($"Book with title {title} not found in the library.");
            }
        }


    }
}
