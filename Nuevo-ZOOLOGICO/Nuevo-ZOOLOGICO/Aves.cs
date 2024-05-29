using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuevo_ZOOLOGICO
{
    internal class Aves:Animales
    {
        public override void AccionEspecial()
        {
            Console.WriteLine("El ave está volando.");
        }
    }
}
