Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var currentDate = DateTime.Now;

Console.WriteLine($"{Environment.NewLine}Hello, {name}! Today is {currentDate:d}.");
Console.WriteLine($"The current time is {currentDate:T}.");

Console.WriteLine("Press any key to exit...");
Console.ReadKey(true);