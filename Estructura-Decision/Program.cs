// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;

Console.WriteLine("Hello, MAN!");
Console.WriteLine("Introduce a text: ");
string texto = Console.ReadLine();
//this loop is to validate thata the text is not empty
while (string.IsNullOrEmpty(texto)||string.IsNullOrWhiteSpace(texto) ){
    Console.WriteLine("please introduce a text, the text is empty: ");
    texto = Console.ReadLine();
}
Console.WriteLine("choice 1 is: uppercase text");
Console.WriteLine("choice 2 is: lowercase text");
Console.WriteLine("choice 3 is: original text ");
Console.Write("choice one option: ");
ConsoleKeyInfo option = Console.ReadKey();
Console.WriteLine("");
//there is a switch to choice the option
switch (option.KeyChar)
{
    case '1':
        Console.WriteLine($"you choice the uppercase text ");
        texto = texto.ToUpper();
        Console.WriteLine(texto);
        break;
    case '2':
        Console.WriteLine($"you choice the lowercase text  ");
        texto = texto.ToLower();
        Console.WriteLine(texto);
        break;
    case '3':
        Console.WriteLine($"you choice the original text  ");
        Console.WriteLine(texto);
        break;
    default:
        Console.WriteLine("you choice a invalid option");
        break;
}

