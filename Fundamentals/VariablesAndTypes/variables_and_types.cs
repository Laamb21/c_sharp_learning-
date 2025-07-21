using System;

namespace variables_and_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize varibales
            int age = 23;               //int
            double weight = 230.1;      //double
            bool isAwesome = true;      //boolean
            string name = "Liam";       // string
            var today = DateTime.Now;   //built-in DateTime type

            //Print variables
            Console.WriteLine($"Hi, my name is {name}.");
            Console.WriteLine($"Today is {today}.");
            Console.WriteLine($"I am {age} years old");
            Console.WriteLine($"I weigh {weight} lbs. ");
            Console.WriteLine($"True or False: {name} is awesome. {isAwesome}!");
        }
    }
}