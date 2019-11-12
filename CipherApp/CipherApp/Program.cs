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

            string message = Encrypt("ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnpqrstuvwxyz", 15, 7);
            Console.WriteLine(message);
            Console.WriteLine(Decrypt(message, 15, 7));

            Console.ReadKey();
        }

        static string Encrypt(string plaintext, int shiftkey1, int shiftkey2)
        {
            string cipherText = "";

            for (int i = 0; i < plaintext.Length; i++)
            {
                int key;
                if (i % 2 == 0)
                {
                    key = shiftkey1;
                }
                else
                {
                    key = shiftkey2;
                }
                
                cipherText = cipherText + EncodeLetter(plaintext[i],key);
            }

            return cipherText;
        }

        static string Decrypt(string cipherText, int shiftkey1, int shiftkey2)
        {
            string plainText = "";

            for (int i = 0; i < cipherText.Length; i++)
            {
                int key;
                if (i % 2 == 0)
                {
                    key = shiftkey1;
                }
                else
                {
                    key = shiftkey2;
                }
                plainText = plainText + DecodeLetter(cipherText[i], key);
            }

            return plainText;
        }

        static char EncodeLetter (char letter, int shiftkey)
        {
            int chrCode = (int)letter;
            if (Char.IsUpper(letter))
            {
                chrCode = chrCode - 65;
                chrCode = chrCode + shiftkey;
                chrCode = chrCode % 26;
                chrCode = chrCode + 65;
            }
            else if (Char.IsLower(letter))
            {
                chrCode = chrCode - 97;
                chrCode = chrCode + shiftkey + 26;
                chrCode = chrCode % 26;
                chrCode = chrCode + 97;
            }

            letter = (char)chrCode;

            return letter;
        }

        static char DecodeLetter(char letter, int shiftkey)
        {
            int chrCode = (int)letter;
            if (Char.IsUpper(letter))
            {
                chrCode = chrCode - 65;
                chrCode = chrCode - shiftkey + 26;
                chrCode = chrCode % 26;
                chrCode = chrCode + 65;
            }
            else if (Char.IsLower(letter))
            {
                chrCode = chrCode - 97;
                chrCode = chrCode - shiftkey + 26;
                chrCode = chrCode % 26;
                chrCode = chrCode + 97;
            }
            letter = (char)chrCode;
            return letter;
        }
    }
}
