// See https://aka.ms/new-console-template for more information
using Clases_Activity;

Console.WriteLine("choice a number to bet between 1 and 6 ");
int number = int.Parse(Console.ReadLine());
while (number>6 || number<1)
{
    Console.WriteLine("choice a number to bet between 1 and 6! pleaseeee!!!! ");
    number = int.Parse(Console.ReadLine());
}


Dice dice = new Dice();
dice.bet(number);

