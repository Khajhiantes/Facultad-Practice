using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuevo_ZOOLOGICO
{
    internal class PlantaCarnivora:Animales
    {
        public override void AccionEspecial()
        {
            Console.WriteLine("La planta carnívora está comiendo a un ser vivo..");
        }
    }
}
