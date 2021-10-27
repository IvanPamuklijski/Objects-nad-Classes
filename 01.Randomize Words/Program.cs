using System;

namespace _01.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            Random rnd = new Random();
            for (int i = 0; i < text.Length; i++)
            {
                int swapPosition = rnd.Next(text.Length);
                string temp = text[i];
                text[i] = text[swapPosition];
                text[swapPosition] = temp;
            }
            Console.WriteLine(string.Join("\n", text));

        }
    }
}
