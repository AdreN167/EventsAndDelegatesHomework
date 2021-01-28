using System;

namespace DelegatesLessonPracticeAndHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var button = new Button<string>
            {
                Border = "*",
                Text = "Кнопка",
                Width = 15,
                Height = 5,
                BorderColor = ConsoleColor.Red,
                FillColor = ConsoleColor.Yellow,
                PushButton = new PushButton<string>(PrintText)
            };

            button.Display();
            button.PushButton("Hello", "world", "!");
        }

        private static void PrintText(params string[] text)
        {
            foreach(var row in text)
            {
                Console.WriteLine(row);
            }
        }
    }
}
