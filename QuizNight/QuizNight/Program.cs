using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNight
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string name;
            int score;

            DisplayQuizName();
            GetUserName(out name);
            PlayQuiz(out score);
            DisplayScore(score);
            AnyKey();
        }

        static void DisplayQuizName()
        {
            Console.Clear();
            Console.WriteLine("Quiz Night!");
            Console.WriteLine("============\n");
        }

        static void GetUserName(out string name)
        {
            Console.WriteLine("Player, please enter your name...");
            Console.Write("Name: ");
            name = Console.ReadLine();
        }

        static void PlayQuiz(out int score)
        {
            //Declare Question Array
            string[,] quiz = {

                {"What is 15.75 in fixed point binary?","11111100" },
                {"What is the smallest number in 8 bit two's complement?","-128" },
                {"What is the biggest number in 4 bit two's complement?","7" },
                {"Where in memory are arrays declared?","The heap" },
                {"Where in memory are variables declared in subroutines?","The stack" },
                {"What is it called when a frame is added to the stack?","pushing" },
                {"what is it called when a fram is removed from the stack?","popping" },
                {"When using parameters in procedures, variables are passed by....","value" },
                {"When using parameters in procedures, objects and arrays are passed by...","reference" },
                {"Which type of subroutine always returns a value?","function" }
            };
            score = 0;
            //Ask the Questions
            for (int i = 0; i < 10; i++)
            {
                DisplayQuizName();
                AskQuestion(quiz[i,0],quiz[i,1], ref score);
            }

        }

        static void DisplayScore(int score)
        {
            Console.WriteLine("\nThe score is : {0}\n", score);
        }

        static void AskQuestion(string question, string answer, ref int score)
        {
            string userAnswer;

            Console.WriteLine(question);
            userAnswer = Console.ReadLine();
            if (userAnswer.ToLower() == answer.ToLower())
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Sorry.\nThe answer is: {0}\n", answer);
            }
            AnyKey();
        }

        static void AnyKey()
        {
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();
        }
    }
}
