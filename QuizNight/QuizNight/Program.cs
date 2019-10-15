using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNight
{
    class Program
    {
        static string name;
        static int score;

        static void Main(string[] args)
        {
            DisplayQuizName();
            GetUserName();
            PlayQuiz();
            DisplayScore();
        }

        static void DisplayQuizName()
        {
            Console.Clear();
            Console.WriteLine("Quiz Night!");
            Console.WriteLine("============\n");
        }

        static void GetUserName()
        {
            Console.WriteLine("Player, please enter your name...");
            Console.Write("Name: ");
            name = Console.ReadLine();
        }

        static void PlayQuiz()
        {

        }

        static void DisplayScore()
        {

        }
    }
}
