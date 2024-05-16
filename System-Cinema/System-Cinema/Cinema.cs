using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Cinema
{
    internal class Cinema
    {
        private User[] espacio;

        public Cinema(int capacidad)
        {
            espacio = new User[capacidad];
        }

        public bool VerifySpace()
        {
            return espacio.Any(User => User == null);
        }

        public void ShowSpace()
        {
            int count = espacio.Count(User => User == null);
            Console.WriteLine($"Hay {count} espacios disponibles");
        }

        public void BuySpace(string name)
        {
            for (int i = 0; i < espacio.Length; i++)
            {
                if (espacio[i] == null)
                {
                    espacio[i] = new User(name);
                    espacio[i].TimeBuy = DateTime.Now;
                    Console.WriteLine($"Espacio comprado a las {espacio[i].TimeBuy}");
                    break;
                }
            }
        }

        public void TotalTime(DateTime entrada, DateTime salida, string name)
        {
            for (int i = 0; i < espacio.Length; i++)
            {
                if (espacio[i] != null && espacio[i].Name == name)
                {
                    espacio[i].TimeArrive = entrada;
                    espacio[i].TimeLeave = salida;
                    TimeSpan total = (TimeSpan)(espacio[i].TimeLeave - espacio[i].TimeArrive);
                    Console.WriteLine($"El tiempo total de {name} en el espacio fue de {total}");
                    break;
                }
            }
        }
    }
}
