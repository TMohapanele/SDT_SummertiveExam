using System;

namespace SectionB_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program to greet the user by name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine(); // Read the user's input from the console and store it in the variable 'name'

            Console.WriteLine("Hello " + name); // Display a greeting message that includes the user's name using string interpolation
        }
    }
}

