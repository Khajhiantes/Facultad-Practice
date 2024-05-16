using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Cinema
{
    internal class User
    {
        public string Name { get; set; }
        public DateTime? TimeBuy { get; set; }
        public DateTime? TimeArrive { get; set; }
        public DateTime? TimeLeave { get; set; }

        public User(string name)
        {
            this.Name = name;
            this.TimeBuy = null;
            this.TimeArrive = null;
            this.TimeLeave = null;
        }
    }
}
