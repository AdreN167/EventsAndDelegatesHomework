using System;

namespace DelegatesLessonPracticeAndHomework
{
    // public delegate void PushButton<T>(params T[] arguments);

    public class Button<T>
    {
        public string Border { get; set; }
        public string Text { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public ConsoleColor BorderColor { get; set; }
        public ConsoleColor FillColor { get; set; }

        public event Action<T[]> Actions;

        public void PushButton(params T[] arguments)
        {
            Actions?.Invoke(arguments);
        }

        public void Display()
        {
            var defaultTextColor = Console.ForegroundColor;
            var defaultBackColor = Console.BackgroundColor;

            Console.ForegroundColor = BorderColor;
            for (int i = 0; i < Width; i++)
            {
                Console.Write(Border);
            }
            Console.ForegroundColor = defaultTextColor;

            Console.WriteLine();

            for (int i = 0; i < Height - 2; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (j == (Width - Text.Length) / 2 && i == (Height - 2) / 2)
                    {
                        Console.BackgroundColor = FillColor;
                        Console.ForegroundColor = BorderColor;
                        Console.Write(Text);
                        Console.ForegroundColor = defaultTextColor;
                        Console.BackgroundColor = defaultBackColor;

                        j += Text.Length;
                    }
                    
                    if (j == 0 || j == Width - 1)
                    {
                        Console.ForegroundColor = BorderColor;
                        Console.Write(Border);
                        Console.ForegroundColor = defaultTextColor;
                    }
                    else
                    {
                        Console.BackgroundColor = FillColor;
                        Console.Write(" ");
                        Console.BackgroundColor = defaultBackColor;
                    }
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = BorderColor;
            for (int i = 0; i < Width; i++)
            {
                Console.Write(Border);
            }
            Console.ForegroundColor = defaultTextColor;
            Console.WriteLine();
        }
    }
}
