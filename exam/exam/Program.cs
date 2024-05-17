// See https://aka.ms/new-console-template for more information
        var sistema = new SistemaDeCorreo(10);
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("1. Enviar correo");
            Console.WriteLine("2. Borrar correo");
            Console.WriteLine("3. Mostrar correos");
            Console.WriteLine("4. Salir");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Entrada inválida. Por favor, introduce un número.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    var correo = new Correo();
                    Console.Write("Remitente: ");
                    correo.Remitente = Console.ReadLine();
                    Console.Write("Destinatario: ");
                    correo.Destinatario = Console.ReadLine();
                    Console.Write("Asunto: ");
                    correo.Asunto = Console.ReadLine();
                    Console.Write("Cuerpo: ");
                    correo.Cuerpo = Console.ReadLine();
                    sistema.EnviarCorreo(correo);
                    break;
                case 2:
                    Console.Write("Introduce el número del correo a borrar: ");
                    int index;
                    if (!int.TryParse(Console.ReadLine(), out index))
                    {
                        Console.WriteLine("Entrada inválida. Por favor, introduce un número.");
                        continue;
                    }
                    sistema.BorrarCorreo(index - 1);
                    break;
                case 3:
                    sistema.MostrarCorreos();
                    break;
                case 4:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no reconocida.");
                    break;
            }
        }

public class Correo
{
    public string Remitente { get; set; }
    public string Destinatario { get; set; }
    public string Asunto { get; set; }
    public string Cuerpo { get; set; }
}

public class SistemaDeCorreo
{
    private Correo[] correos;
    private int contador = 0;

    public SistemaDeCorreo(int capacidad)
    {
        correos = new Correo[capacidad];
    }

    public void EnviarCorreo(Correo correo)
    {
        if (contador < correos.Length)
        {
            correos[contador] = correo;
            contador++;
        }
        else
        {
            Console.WriteLine("No hay espacio para más correos.");
        }
    }

    public void BorrarCorreo(int index)
    {
        if (index >= 0 && index < contador)
        {
            for (int i = index; i < contador - 1; i++)
            {
                correos[i] = correos[i + 1];
            }
            contador--;
        }
    }

    public void MostrarCorreos()
    {
        for (int i = 0; i < contador; i++)
        {
            var correo = correos[i];
            Console.WriteLine($"Correo {i + 1}:");
            Console.WriteLine($"Remitente: {correo.Remitente}");
            Console.WriteLine($"Destinatario: {correo.Destinatario}");
            Console.WriteLine($"Asunto: {correo.Asunto}");
            Console.WriteLine($"Cuerpo: {correo.Cuerpo}");
            Console.WriteLine();
        }
    }
}


        