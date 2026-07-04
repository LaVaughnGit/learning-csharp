using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 4;
            Console.WriteLine("Hello, World!");
            Console.WriteLine(5 + 5);
            Console.WriteLine(4 * 10);
            Console.WriteLine($"Hi there! The current date is {DateTime.Now:d}.");
            Console.WriteLine($"Is x greater than 5? {x > 5}");
            Console.WriteLine($"❤️ 👽 The value of x is {x}.");
            Console.WriteLine($"The time is currently: {DateTime.Now:t}");

            // This is a comment.
            Console.WriteLine("Post comment line.\nYOLO!");

            /* 
             * Multi-line comments noice.
             * 
             */
        }
    }
}