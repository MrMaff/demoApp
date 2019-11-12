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

            for (int i = 0; i < plaintext.Length; i++)
            {
                int chrCode = (int) plaintext[i];
                if (Char.IsUpper(plaintext[i]))
                {
                    chrCode = chrCode - 65;
                    chrCode = chrCode + shiftkey;
                    chrCode = chrCode % 26;
                    chrCode = chrCode + 65;
                }
                else if (Char.IsLower(plaintext[i]))
                {
                    chrCode = chrCode - 97;
                    chrCode = chrCode + shiftkey + 26;
                    chrCode = chrCode % 26;
                    chrCode = chrCode + 97;
                }
                cipherText = cipherText + (char)chrCode;
            }

            return cipherText;
        }

        static string Decrypt(string cipherText, int shiftkey)
        {
            string plainText = "";

            for (int i = 0; i < cipherText.Length; i++)
            {
                int chrCode = (int)cipherText[i];
                if (Char.IsUpper(cipherText[i]))
                {
                    chrCode = chrCode - 65;
                    chrCode = chrCode - shiftkey + 26;
                    chrCode = chrCode % 26;
                    chrCode = chrCode + 65;
                }
                else if (Char.IsLower(cipherText[i]))
                {
                    chrCode = chrCode - 97;
                    chrCode = chrCode - shiftkey + 26;
                    chrCode = chrCode % 26;
                    chrCode = chrCode + 97;
                }
                plainText = plainText + (char)chrCode;
            }

            return plainText;
        }
    }
}
