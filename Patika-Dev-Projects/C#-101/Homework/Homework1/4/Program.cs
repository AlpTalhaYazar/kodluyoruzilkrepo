using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence to below...");
            string sentence1 = Console.ReadLine();

            string[] splittedSentence1 = sentence1.Split(" ");

            int wordAmount = splittedSentence1.Length;
            int letterAmount = string.Join("", splittedSentence1).Length;

            System.Console.WriteLine($"Total word amount inside your sentence is : {wordAmount}\nTotal letter amount inside your sentence is : {letterAmount}(without white spaces)");
        }
    }
}
