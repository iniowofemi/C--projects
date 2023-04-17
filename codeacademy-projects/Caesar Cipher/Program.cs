using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.WriteLine("What message fo you wish to translate? ");
            string msg = Console.ReadLine();
            char[] secretMessage = msg.ToCharArray();

            char[] encryptedArray = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                int index = Array.IndexOf(alphabet, letter);
                encryptedArray[i] = alphabet[(index + 3) % alphabet.Length];
            }
            string encryptedMessage = String.Join("", encryptedArray);
            Console.WriteLine(encryptedMessage);
        }
    }
}