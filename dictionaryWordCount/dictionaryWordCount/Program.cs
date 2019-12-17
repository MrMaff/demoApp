using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryWordCount
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> words = new Dictionary<string, int>();
            string sentance = "Hello, this is me saying hello. I hope you are well. It is quite important that you do feel well, at least that's what I think.".ToLower();
            string[] seperators = { ". ", ", ", " ", "! " };
            string[] wordArray = sentance.Split(seperators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in wordArray)
            {
                
                if (words.ContainsKey(word))
                {
                    words[word] = words[word] + 1;
                }
                else
                {
                    words.Add(word, 1);
                }
            }


            var sorted = words.OrderBy(temp =>temp.Value);

            foreach (KeyValuePair<string, int> word in sorted)
            {
                Console.WriteLine(word.Key + " " + word.Value);
            }

            //foreach (KeyValuePair<string, int> definition in words)
            //{
            //    Console.WriteLine(definition.Key + " " + definition.Value);
            //}

            Console.ReadKey();
        }
    }
}
