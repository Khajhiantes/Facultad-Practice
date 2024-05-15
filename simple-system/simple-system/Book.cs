using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_system
{
    internal class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public double price { get; set; }
        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }
    }
}
