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
            Console.WriteLine("============/n");
        }

        static void GetUserName()
        {
            Console.WriteLine("Player, please enter your name...");
            Console.Write("Name: ");
            name = Console.ReadLine();
        }

        static void PlayQuiz()
        {
            string[,] quiz = {

                {"What is 15.75 in fixed point binary?","11111100" },
                {"What is the smallest number in 8 bit two's complement?","-128" },
                {"What is the biggest number in 4 bit two's complement?","7" },
                {"Where in memory are arrays declared?","The heap" },
                {"Where in memory are variables declared in subroutines?","The stack" },
                {"What is it called when a frame is added to the stack?","pushing" },
                {"what is it called when a fram is removed from the stack?","popping" },
                {"","" },
                {"","" },
                {"","" }
            };


            for (int i = 0; i < 10; i++)
            {
                DisplayQuizName();
                AskQuestion();
            }

        }

        static void DisplayScore()
        {
            Console.WriteLine("/nThe score is : {0}/n", score);
        }

        static void AskQuestion(string question, string answer)
        {

        }
    }
}
