using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace parking
{
    internal class Parking
    {
      
        public DateTime horaSalida { get; set; }
        public Car[] espacio;


        public  Parking(int capacidad)
        {
            espacio = new Car[capacidad];
        }
        public void showCar()
        {
            int count = 0;
            for (int i = 0; i<espacio.Length; i++)
            {
                if (espacio[i] == null)
                {
                    count++;
                }
            }
            Console.WriteLine($"Hay {count} espacios disponibles"); 
        }
        public void IntroduceCar(Car car)
        {
            for(int i = 0; i<espacio.Length; i++)
            {
                if (espacio[i] == null)
                {
                    espacio[i] = car;
                    break;
                }
            }
        }

        public void costoEstacinamiento(DateTime horaSalida, string placa)
        {
            for (int i = 0; i < espacio.Length; i++)
            {
                if (espacio[i] != null && espacio[i].placa == placa)
                {
                    TimeSpan time = horaSalida - espacio[i].horaEntrada;
                    int totalHoras = Convert.ToInt32(Math.Ceiling(time.TotalHours));
                    espacio[i] = null; // Libera el espacio de estacionamiento
                    Console.WriteLine($"El costo del estacionamiento es de {totalHoras * 2} dolares deaa");
                    return;
                }
            }
            Console.WriteLine("No se encontro el vehiculo");
        }


    }
}
