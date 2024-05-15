/*¡Por supuesto! Aquí tienes otro ejercicio para practicar:
Imagina que estás creando un juego de lanzamiento de monedas. En este juego, dos jugadores lanzan una moneda 
y el resultado puede ser cara o cruz. Las reglas son las siguientes: si ambos jugadores obtienen el mismo resultado,
es un empate. Si no, el jugador que obtiene cara gana. El juego continúa hasta que un jugador gane 3 rondas.
Aquí están los detalles:
1.Cada jugador lanza una moneda, obteniendo cara o cruz.
2.	Se determina el ganador de la ronda según las reglas del juego.
3.	El juego continúa hasta que un jugador gane 3 rondas.*/

using System;
using Flip_a_Coin;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the name of player 1:");
        string player1Name = Console.ReadLine();

        Console.WriteLine("Enter the name of player 2:");
        string player2Name = Console.ReadLine();

        Game game = new Game(player1Name, player2Name);
        game.Play();
    }
}