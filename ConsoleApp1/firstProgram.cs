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

            int y1 = 10;
            Console.WriteLine($"The value of y1 is {y1}.");
            double y2 = 20.1;
            Console.WriteLine($"The value of y2 is {y2}.");
            int y3 = 30;
            Console.WriteLine($"The value of y3 is {y3}.");
            bool y4 = true;
            Console.WriteLine($"The value of y4 is {y4}.");

            char a = 'A';
            Console.WriteLine($"The value of a is {a}.");
            string b = "Whats up!";
            Console.WriteLine($"The value of b is {b}.");

            const double pi = 3.14159;
            Console.WriteLine($"pi is {pi}.");

            //pi = 3.14; // This line will cause a compile-time error because pi is a constant and cannot be reassigned.

            int x1, x2, x3;
            x1 = 5;
            x2 = 10;
            x3 = x1 + x2;
            Console.WriteLine($"The value of x3 is {x3}.");

            // Explicit Conversion
            double d = 9.78;
            int i = (int)d; // Changes double to int, truncating the decimal part
            Console.WriteLine($"The value of i is {i}.");
        }
    }
}