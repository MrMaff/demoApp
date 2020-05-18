using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();

            while (game.gameState == 0)
            {
                game.DisplayPlayerCredits();

                game.PlayRound();

                AnyKey();
                Console.Clear();
            }

            if (game.gameState == GameState.Lost)
            {
                Console.WriteLine("Sorry You lost all your Credits!");
            }
            else
            {
                Console.WriteLine("Congratulations you have beaten the house!");
            }
            AnyKey();


        }

        static void AnyKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
