using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string message = Encrypt("Cheese Please!", 15);
            Console.WriteLine(message);
            Console.WriteLine(Decrypt(message, 15));

            Console.ReadKey();
        }

        static string Encrypt(string plaintext, int shiftkey)
        {
            string cipherText = "";
            //Enter code to encrypt message here
            return cipherText;
        }

        static string Decrypt(string cipherText, int shiftkey)
        {
            string plainText = "";
            //Enter code to decrypt message here
            return plainText;
        }
    }
}
