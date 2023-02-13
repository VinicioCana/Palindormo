using System;
using System.Linq;

namespace PalindromeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa una frase o texto:");
            string input = Console.ReadLine();

            var palindromes = FindPalindromes(input);
            Console.WriteLine($"Hay {palindromes.Count()} palíndromos en el texto:");
            foreach (var palindrome in palindromes)
            {
                Console.WriteLine(palindrome);
            }

            Console.ReadLine();
        }

        static bool IsPalindrome(string input)
        {
            int length = input.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (input[i] != input[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        static string[] FindPalindromes(string input)
        {
            string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?' });

            return words.Where(word => IsPalindrome(word)).ToArray();
        }
    }
}