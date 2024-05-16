// See https://aka.ms/new-console-template for more information
using System_Cinema;

using System_Cinema;

Cinema cinema = new Cinema(3);
while (cinema.VerifySpace())
{
    Console.WriteLine("Desea comprar un boleto?");
    Console.WriteLine("s/n");
    string request = Console.ReadLine();
    if (request.ToLower() == "s")
    {
        Console.WriteLine("Ingrese su nombre");
        string name = Console.ReadLine();
        cinema.BuySpace(name);
    }
    Console.WriteLine("Desea ver el espacio disponible?");
    Console.WriteLine("s/n");
    string space = Console.ReadLine();
    if (space.ToLower() == "s")
    {
        cinema.ShowSpace();
    }
    Console.WriteLine("Este es un ejemplo del formato que deseo que ingrese" + DateTime.Now);
    Console.WriteLine("Cuando ingreso?");
    DateTime ingreso;
    if (!DateTime.TryParse(Console.ReadLine(), out ingreso))
    {
        Console.WriteLine("Formato de fecha incorrecto");
        continue;
    }
    Console.WriteLine("Cuando salio?");
    DateTime salida;
    if (!DateTime.TryParse(Console.ReadLine(), out salida))
    {
        Console.WriteLine("Formato de fecha incorrecto");
        continue;
    }
    Console.WriteLine("Ingrese el nombre del usuario que busca");
    string search = Console.ReadLine();
    cinema.TotalTime(ingreso, salida, search);
}
Console.WriteLine("sold out!");
