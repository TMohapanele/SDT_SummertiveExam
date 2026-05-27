using System;

namespace SectionB_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: "); // Prompt the user to enter their name
            string name = Console.ReadLine(); // Read the user's input and store it in the variable 'name'

            Console.Write($"Hello {name}"); // Display a greeting message that includes the user's name using string interpolation
        }
    }
}