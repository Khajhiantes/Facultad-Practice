// See https://aka.ms/new-console-template for more information


using simple_system;

Library library = new Library();
Book books = new Book("1984", "George Orwell", 9.99);

library.SetBook(books);
// Aquí puedes imprimir el título del libro en la librería para verificar que se ha establecido correctamente
Console.WriteLine(library.book.title);

library.sellBook();
// Aquí puedes intentar imprimir el título del libro en la librería para verificar que se ha vendido (debería dar un error porque el libro es null)
Console.WriteLine(library.book.author);