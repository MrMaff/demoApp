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

            while (game.GameState == 0)
            {
                game.DisplayPlayerCredits();

                game.PlayRound();

                AnyKey();
                Console.Clear();
            }

            if (game.GameState == GameStates.Lost)
            {
                Console.WriteLine("Sorry You lost all your Credits!");
            }
            else
            {
                Console.WriteLine("Congratulations you have beaten the house!");
                game.DisplayPlayerCredits();
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
