using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    internal class Tasks
    {
        public string title { get; set; }
        public string description { get; set; }
        public bool status { get; set; }

        public Tasks() 
        {
            status = false;
        }

    }
}
