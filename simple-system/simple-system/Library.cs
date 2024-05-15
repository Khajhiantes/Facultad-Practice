using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_system
{
    internal class Library
    {
        public Book book { get; set; }
        public void SetBook(Book boook)
        {
            book = boook;
        }
        public void sellBook()
        {
            book = null;
        }

    }
}
