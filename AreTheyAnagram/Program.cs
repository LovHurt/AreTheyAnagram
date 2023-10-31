using System;

namespace AnagramChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first word:");
            string word1 = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the second word:");
            string word2 = Console.ReadLine().ToLower();

            if (AreAnagrams(word1, word2))
            {
                Console.WriteLine($"{word1} and {word2} are anagrams.");
            }
            else
            {
                Console.WriteLine($"{word1} and {word2} are not anagrams.");
            }

            Console.ReadLine();
        }

        static bool AreAnagrams(string word1, string word2)
        {
            // Remove spaces and convert the strings to character arrays
            char[] charArray1 = word1.Replace(" ", "").ToCharArray();
            char[] charArray2 = word2.Replace(" ", "").ToCharArray();

            // Check if the lengths of the character arrays are equal
            if (charArray1.Length != charArray2.Length)
            {
                return false;
            }

            // Sort both character arrays
            Array.Sort(charArray1);
            Array.Sort(charArray2);

            // Compare the sorted character arrays
            for (int i = 0; i < charArray1.Length; i++)
            {
                if (charArray1[i] != charArray2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}