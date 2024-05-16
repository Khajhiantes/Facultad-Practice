using parking;
using System.Globalization;

Parking parking = new Parking(10);

while (parking.espacio.Any(e => e == null)) // Check if there is any empty space
{
    Console.WriteLine("Welcome!");
    Console.WriteLine("En este momento: ");
    parking.showCar();

    Car car = new Car(); // Create a new Car object for each car

    Console.WriteLine("Introduzca su placa: ");
    car.placa = Console.ReadLine();

    parking.IntroduceCar(car);

    Console.WriteLine("Hora de entrada: " + car.horaEntrada);

    Console.WriteLine("Desea salir? (s/n)");
    string respuesta = Console.ReadLine();

    if (respuesta.ToLower() == "s")
    {
        Console.WriteLine("Introduzca la placa del auto que desea sacar: ");
        string placa = Console.ReadLine();

        Console.WriteLine("Hora de salida: ");
        try
        {
            DateTime horaSalida = DateTime.Parse(Console.ReadLine());
            parking.costoEstacinamiento(horaSalida, placa);
        }
        catch (FormatException)
        {
            Console.WriteLine("La hora de salida introducida no es válida. Por favor, introduzca la hora en el formato correcto.");
        }
    }
}

