using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Nice to meet you?");
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"{name}, Do you like animals?");
            var next = Console.ReadLine();
            Console.WriteLine($"Your answer is {next}. Well then, {name}, What is your fav animal?");
            var animal = Console.ReadLine();
            Console.WriteLine($"Really {name}, I like {animal} too!");

        }
    }
}
