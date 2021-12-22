using System;
using System.Linq;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello please enter a positive integer");
            int positiveInteger1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter {positiveInteger1} amount positive integer(press Enter after each integer to submit)");
            int[] nums1 = new int[positiveInteger1];
            for (int i = 0; i < positiveInteger1; i++)
            {
                nums1[i] = int.Parse(Console.ReadLine());
            }
            
            foreach (var num1 in nums1.FindEvens())
                Console.WriteLine(num1);
        }
    }

    public static class Extension
    {
        public static int[] FindEvens(this int[] input)
        {
            input = input.Where(x => x % 2 == 0).ToArray();
            return input;
        }
    }
}
