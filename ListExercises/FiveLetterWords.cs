using System;
using System.Collections.Generic;

namespace ListExercises
{
    public class FiveLetterWords
    {
        public static void WordSelector(List<string> words)
        {
            Console.WriteLine("Enter a number of letters:");
            string input = Console.ReadLine();
            int letterCount = int.Parse(input);

            foreach (string word in words)
            {
                if (word.Length == letterCount)
                {
                    Console.WriteLine(word);
                }
            }
            
        }
    }
}
