/*¡Por supuesto! Aquí tienes otro ejercicio para practicar:
Imagina que estás creando un juego de piedra, papel o tijeras. En este juego, dos jugadores eligen una de las tres opciones y se enfrentan. 
Las reglas son las siguientes: la piedra gana a las tijeras, las tijeras ganan al papel y el papel gana a la piedra. 
Si ambos jugadores eligen la misma opción, es un empate.
Aquí están los detalles:
1.Cada jugador elige una opción: piedra, papel o tijeras.
2.	Se determina el ganador de la ronda según las reglas del juego.
3.	El juego continúa hasta que un jugador gane 3 rondas.*/
using System;
namespace GameRock
{
    enum Move
    {
        rock,
        scissors,
        paper
    }
    public class Player
    {
        public int life = 0;

        public void winRound()
        {
            life++;
        }
        public void draw()
        {
            life = life;
        }
    }
    class Game
    {
        public static void Main(string[] args)
        {
            Player player1 = new Player();
            Player player2 = new Player();
            Console.WriteLine("Welcome to the game Rock, Paper, Scissors");
            while(player1.life<3 && player2.life < 3)
            {
                Console.WriteLine("Player 1");
                Console.WriteLine("Choose your move: 1 for Rock, 2 for Scissors, 3 for Paper");
                Move move1 = (Move)(int.Parse(Console.ReadLine()) - 1);
                Console.WriteLine("Player 2");
                Console.WriteLine("Choose your move: 1 for Rock, 2 for Scissors, 3 for Paper");
                Move move2 = (Move)(int.Parse(Console.ReadLine()) - 1);
                if (move2==move1)
                {
                    player2.draw();
                    player1.draw(); 
                }
                else
                {
                    if(move1 == Move.rock && move2 == Move.scissors )
                    {
                        player1.winRound();
                    }
                    else if(move1==Move.scissors && move2==Move.paper)
                    {
                        player1.winRound();
                    }
                    else if(move1==Move.paper && move2==Move.rock)
                    {
                        player1.winRound();
                    }
                    else
                    {
                        player2.winRound();
                    }
                }


            }
            if (player1.life == 3)
            {
                Console.WriteLine("Player 1 wins");
            }
            else
            {
                Console.WriteLine("Player 2 wins");
            }

        }
    }

}