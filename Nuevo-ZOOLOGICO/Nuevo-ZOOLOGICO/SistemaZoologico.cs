using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuevo_ZOOLOGICO
{
    internal class SistemaZoologico
    {
        public List<Animales> Animales { get; set; } = new List<Animales>();
        public List<Cuidadores> Cuidadores { get; set; } = new List<Cuidadores>();

        public void AgregarAnimal(Animales animal) 
        {
            Animales.Add(animal);
        }
        public void AgregarCuidador(Cuidadores cuidador) 
        {
            Cuidadores.Add(cuidador);
        }

        public void EliminarCuidadores(Cuidadores cuidador) 
        { 
            Cuidadores.Remove(cuidador);
        }
        public void EliminarAnimal(Animales animal) 
        {
            Animales.Remove(animal);
        }
        public void ActualizarAnimal(string nombreOriginal, string nuevoNombre, string nuevaEspecie, string nuevaComida)
        {
            var animal = Animales.FirstOrDefault(a => a.Nombre == nombreOriginal);
            if (animal != null)
            {
                animal.Nombre = nuevoNombre;
                animal.Especie = nuevaEspecie;
                animal.Comida = nuevaComida;
            }
        }

        public void ActualizarCuidador(string nombreOriginal, string nuevoNombre)
        {
            var cuidador = Cuidadores.FirstOrDefault(c => c.Nombre == nombreOriginal);
            if (cuidador != null)
            {
                cuidador.Nombre = nuevoNombre;
            }
        }
        public void MostrarCuidadores() 
        {
            foreach (var cuidador in Cuidadores)
            {
                Console.WriteLine($"Nombre: {cuidador.Nombre}");
            }
        }
        public void MostrarAnimales() 
        {
            foreach (var animal in Animales)
            {
                Console.WriteLine($"Nombre: {animal.Nombre}, Especie: {animal.Especie}, Comida: {animal.Comida}");
            }
        }

        
    }
}
