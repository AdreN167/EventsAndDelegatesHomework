using System;

namespace DelegatesLessonPracticeAndHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringButton = new Button<string>
            {
                Border = "*",
                Text = "String",
                Width = 15,
                Height = 5,
                BorderColor = ConsoleColor.Red,
                FillColor = ConsoleColor.Yellow,
            };

            stringButton.Display();

            stringButton.Actions += message => 
            { 
                foreach (var word in message)
                    Console.Write(word); 
            };
            stringButton.Actions += enter => Console.WriteLine();
            stringButton.Actions += enter => Console.WriteLine();

            stringButton.PushButton("Привет", ",", " мир!");

            var intButton = new Button<int>
            {
                Border = "o",
                Text = "Int",
                Width = 20,
                Height = 5,
                BorderColor = ConsoleColor.Yellow,
                FillColor = ConsoleColor.Blue,
            };

            intButton.Display();

            intButton.Actions += numbers => 
            {
                int sum = 0;
                foreach (var number in numbers)
                    sum += number;
                Console.WriteLine($"Sum = {sum}");
            };

            intButton.PushButton(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        }
    }
}
