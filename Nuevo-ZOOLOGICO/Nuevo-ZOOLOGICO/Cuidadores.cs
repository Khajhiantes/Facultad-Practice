using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Nuevo_ZOOLOGICO
{
    internal class Cuidadores
    {
        public string Nombre;
        public void Alimentar(Animales animal)
        {
            Console.WriteLine($"{Nombre} está alimentando a {animal.Nombre}.");
            animal.Comer();
        }
    }
}
