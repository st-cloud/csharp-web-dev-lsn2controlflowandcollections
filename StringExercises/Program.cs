using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Strings!");

            string firstString = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

            string[] wordsArray = firstString.Split(" ");

            Console.WriteLine(string.Join(",", wordsArray));

            string[] sentencesArray = firstString.Split(". ");

            Console.WriteLine(string.Join(" STOP ", sentencesArray));

            Console.ReadLine();
        }
    }
}
