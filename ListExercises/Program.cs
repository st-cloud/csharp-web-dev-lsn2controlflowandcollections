using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");

            List<int> numbas = new List<int> { 1, 4, 5, 8, 13, 14, 17, 22, 27, 120 };

            SumOfEvenNumbers.SumEven(numbas);

            List<string> palabras = new List<string> { "hello", "mundo", "bananas", "territory", "gates", "fish" };

            FiveLetterWords.WordSelector(palabras);

            Console.ReadLine();
        }
    }
}
