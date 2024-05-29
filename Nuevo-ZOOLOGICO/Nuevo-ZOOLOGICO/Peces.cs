using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuevo_ZOOLOGICO
{
    internal class Peces:Animales
    {
        public override void AccionEspecial()
        {
            Console.WriteLine("El pez está nadando.");
        }
    }
}
