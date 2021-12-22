using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello please enter a positive integer");
            int positiveInteger1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter {positiveInteger1} amount word(press Enter after each integer to submit)");
            string[] words1 = new string[positiveInteger1];
            for (int i = 0; i < positiveInteger1; i++)
            {
                words1[i] = Console.ReadLine();
            }

            Array.Reverse(words1);

            foreach (var word1 in words1)
                Console.WriteLine(word1);
        }
    }
}
