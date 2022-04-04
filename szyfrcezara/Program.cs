using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Chesz zaszyfrować?\nWybierz Opcje:\n1.-Zaszyfrowac ");
            int val = Convert.ToInt32(Console.ReadLine());

            switch (val)
            {
                case 1:
                    Console.WriteLine("Wpisz teskt który chcesz zaszyfrować: ");
                    string msgString = Console.ReadLine();
                    msgString = msgString.ToLower();
                    char[] secretMessage = msgString.ToCharArray();
                    Encrypt(secretMessage, 3);
                    string secret = Encrypt(secretMessage, 3);
                    Console.WriteLine(secret);
                    break;

            }
        }
        static string Encrypt(char[] secretMessage, int key)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            int length = secretMessage.Length;
            //Console.WriteLine(length);
            char[] encryptedMessage = new char[length];
            for (int i = 0; i < secretMessage.Length; i++)
            {
                var letter = secretMessage[i];
                int index = Array.IndexOf(alphabet, letter);
                int newIndex = (key + index) % 26;
                char newLetter = alphabet[newIndex];
                encryptedMessage[i] = newLetter;
                //Console.WriteLine($"{letter}, {index}");
            }

            string enMessage = String.Join("", encryptedMessage);
            //Console.WriteLine(enMessage);
            return enMessage;
        }
    }
}
