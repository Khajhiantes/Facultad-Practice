using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System_OOP_
{
    internal class Book: Ibook
    {

        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public void Read()
        {
            Console.WriteLine($"Reading a {Title} by {Author}");
        }
    }
    
  
}
