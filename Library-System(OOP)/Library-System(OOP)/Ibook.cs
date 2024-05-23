using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System_OOP_
{
    internal interface Ibook
    {
        string Title { get; set; }
        string Author { get; set; }
        int Pages { get; set; }
        void Read();
    }
}
