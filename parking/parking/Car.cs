using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parking
{
    internal class Car
    {
        public string placa { get; set; }
        public DateTime horaEntrada { get; set; }

        public Car()
        {
            this.placa = placa;
            horaEntrada = DateTime.Now;
        }

    }
}
