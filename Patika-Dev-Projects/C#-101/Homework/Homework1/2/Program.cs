using System;
using System.Linq;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello please enter 2 positive integer");
            int positiveInteger1 = int.Parse(Console.ReadLine());
            int positiveInteger2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Please enter {positiveInteger1} amount positive integer(press Enter after each integer to submit)");
            int[] nums1 = new int[positiveInteger1];
            for (int i = 0; i < positiveInteger1; i++)
            {
                nums1[i] = int.Parse(Console.ReadLine());
            }

            foreach (var num1 in FindEqualAndFactors(positiveInteger2, nums1))
                Console.WriteLine(num1);
        }

        public static int[] FindEqualAndFactors(int inputInteger, int[] inputArray)
        {
            inputArray = inputArray.Where(x => x % inputInteger == 0).ToArray();
            return inputArray;
        }
    }
}
