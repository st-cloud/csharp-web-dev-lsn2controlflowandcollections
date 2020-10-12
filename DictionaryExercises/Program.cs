using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> students = new Dictionary<int, string>();
            string input;
            int newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            do
            {
                Console.WriteLine("Student ID: ");
                input = Console.ReadLine();

                if (!Equals(input, ""))
                {
                    newStudent = int.Parse(input);
                    Console.WriteLine("Student Name: ");
                    string name = Console.ReadLine();
                    students.Add(newStudent, name);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(input, ""));

            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }

            Console.ReadLine();

        }
    }
}



