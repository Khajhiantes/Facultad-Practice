using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuevo_ZOOLOGICO
{
    internal class Animales
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Comida { get; set; }
        public virtual void AccionEspecial() { }
        public virtual void Comer()
        {
            Console.WriteLine($"{Nombre} está comiendo {Comida}.");
        }

    }
}
