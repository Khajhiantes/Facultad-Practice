// See https://aka.ms/new-console-template for more information
using Nuevo_ZOOLOGICO;

SistemaZoologico zoologico = new SistemaZoologico();

while (true)
{
    Console.WriteLine("1. Agregar animal");
    Console.WriteLine("2. Agregar cuidador");
    Console.WriteLine("3. Aplicar habilidad especial a animal");
    Console.WriteLine("4. Actualizar animal");
    Console.WriteLine("5. Actualizar cuidador");
    Console.WriteLine("6. Eliminar animal");
    Console.WriteLine("7. Eliminar cuidador");
    Console.WriteLine("8. Mostrar animales");
    Console.WriteLine("9. Mostrar cuidadores");
    Console.WriteLine("10. Salir");

    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese el tipo de animal (mamifero, ave, pez, planta):");
            string tipoAnimal = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del animal:");
            string nombreAnimal = Console.ReadLine();

            Console.WriteLine("Ingrese la especie del animal:");
            string especie = Console.ReadLine();

            Console.WriteLine("Ingrese la comida del animal:");
            string comida = Console.ReadLine();

            Animales animal;
            switch (tipoAnimal.ToLower())
            {
                case "mamifero":
                    animal = new Mamiferos { Nombre = nombreAnimal, Especie = especie, Comida = comida };
                    break;
                case "ave":
                    animal = new Aves { Nombre = nombreAnimal, Especie = especie, Comida = comida };
                    break;
                case "pez":
                    animal = new Peces { Nombre = nombreAnimal, Especie = especie, Comida = comida };
                    break;
                case "planta":
                    animal = new PlantaCarnivora { Nombre = nombreAnimal, Especie = especie, Comida = comida };
                    break;
                default:
                    Console.WriteLine("Tipo de animal no válido.");
                    continue;
            }

            zoologico.AgregarAnimal(animal);

            break;
        case 2:
            Console.WriteLine("Ingrese el nombre del cuidador:");
            string nombreCuidador = Console.ReadLine();
            Cuidadores cuidador = new Cuidadores { Nombre = nombreCuidador };
            zoologico.AgregarCuidador(cuidador);
            break;
        case 3:
            Console.WriteLine("Ingrese el nombre del animal:");
            string nombreAnimalEspecial = Console.ReadLine();

            Animales animalEspecial = zoologico.Animales.FirstOrDefault(a => a.Nombre == nombreAnimalEspecial);
            if (animalEspecial != null)
            {
                animalEspecial.AccionEspecial();
            }

            break;
        case 4:
            Console.WriteLine("Ingrese el nombre original del animal:");
            string nombreOriginal = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo nombre del animal:");
            string nuevoNombre = Console.ReadLine();

            Console.WriteLine("Ingrese la nueva especie del animal:");
            string nuevaEspecie = Console.ReadLine();

            Console.WriteLine("Ingrese la nueva comida del animal:");
            string nuevaComida = Console.ReadLine();

            zoologico.ActualizarAnimal(nombreOriginal, nuevoNombre, nuevaEspecie, nuevaComida);
            break;
        case 5:
            Console.WriteLine("Ingrese el nombre original del cuidador:");
            string nombreOriginalCuidador = Console.ReadLine();

            Console.WriteLine("Ingrese el nuevo nombre del cuidador:");
            string nuevoNombreCuidador = Console.ReadLine();

            zoologico.ActualizarCuidador(nombreOriginalCuidador, nuevoNombreCuidador);
            break;
        case 6:
            Console.WriteLine("Ingrese el nombre del animal a eliminar:");
            string nombreAnimalEliminar = Console.ReadLine();

            Animales animalEliminar = zoologico.Animales.FirstOrDefault(a => a.Nombre == nombreAnimalEliminar);
            if (animalEliminar != null)
            {
                zoologico.EliminarAnimal(animalEliminar);
            }

            break;
        case 7:
            Console.WriteLine("Ingrese el nombre del cuidador a eliminar:");
            string nombreCuidadorEliminar = Console.ReadLine();

            Cuidadores cuidadorEliminar = zoologico.Cuidadores.FirstOrDefault(c => c.Nombre == nombreCuidadorEliminar);
            if (cuidadorEliminar != null)
            {
                zoologico.EliminarCuidadores(cuidadorEliminar);
            }

            break;
        case 8:
            zoologico.MostrarAnimales();
            break;
        case 9:
            zoologico.MostrarCuidadores();
            break;
        case 10:
            return;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}