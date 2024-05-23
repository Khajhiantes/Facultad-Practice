// See https://aka.ms/new-console-template for more information
using Library_System_OOP_;

var book1 = new Book { Title = "Book1", Author = "Author231", Pages = 200 };
var book2 = new Book { Title = "Book2", Author = "Author2", Pages = 300 };

var library = new Library();
library.AddBook(book1);
library.AddBook(book2);
library.ReadBook("Book3");

