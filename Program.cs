using System;

namespace Oppgave01_Hvagjordennekoden
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            int totalLetters = 0;

            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine().ToLower();
                foreach (var character in text ?? string.Empty)
                {
                    totalLetters++;
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        var percentage = 100 * (double)counts[i] / totalLetters;
                        string output = "\"" + character + "\" - " + counts[i] + ", Percentage: " + percentage.ToString("F2") + "%";
                        Console.CursorLeft = Console.BufferWidth - output.Length - 1;
                        Console.WriteLine(output);
                    }
                }
            }
        }
    }
}
