using System;

namespace Methods
{
    static class Program
    {
        static void Main()
        {
            #region Method Definition

            //  access_modifier return_type method_name(parameters)
            //  {
            //      commands;....
            //      return;
            //  }

            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            // we dont need instance of class if we declare as Static
            int result = Sum(a, b);
            Console.WriteLine(result);

            // But we need instance of that class because neither class nor method is static
            Methods sample = new Methods();
            int result2 = sample.IncreaseAndSum(ref a, ref b);
            Console.WriteLine(result2);

            #endregion

            #region Method Overloading

            // out parameter
            string num = "999";

            bool result3 = int.TryParse(num, out int outNum);
            if (result3)
            {
                Console.WriteLine("Successfull");
                Console.WriteLine(outNum);
            }
            else
            {
                Console.WriteLine("Failure");
            }

            Methods sample2 = new Methods();
            sample2.Sum(4, 5, out int summaryResult);
            Console.WriteLine(summaryResult);

            // Method Overloading
            sample2.Sum(4, 5, 6, out int summartResult2);
            Console.WriteLine(summartResult2);
            sample2.Sum(4, "5", out int summaryResult3);
            Console.WriteLine(summaryResult3);

            #endregion

            #region Recursive and Extension Methods

            // Recursive - function that calls itself
            // 3 ^ 4
            int result4 = 1;
            for (int i = 0; i < 4; i++)
                result4 *= 3;

            Console.WriteLine(result4);

            System.Console.WriteLine(sample2.pow(3, 4));

            // Extension Methods
            string text = "is there any space";
            System.Console.WriteLine(text);
            System.Console.WriteLine(text.IsThereSpace());
            System.Console.WriteLine(text.RemoveWhiteSpaces());
            System.Console.WriteLine(text.MakeUpperCase());

            int[] nums = { 9, 3, 6, 2, 1, 5, 0 };
            nums.SortArray();
            nums.PrintOnScreen();
            System.Console.WriteLine(5.IsEvenNumber());
            System.Console.WriteLine(6.IsEvenNumber());

            System.Console.WriteLine(text.GetFirsChar());
            
            #endregion
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
    class Methods
    {
        public int IncreaseAndSum(ref int num1, ref int num2)
        {
            return ++num1 + ++num2;
        }

        public void Sum(int a, int b, out int summary)
        {
            summary = a + b;
        }

        // Using same method name with different parameters or different parameter types
        // We are overloading Sum method
        public void Sum(int a, int b, int c, out int summary)
        {
            summary = a + b + c;
        }
        public void Sum(int a, string b, out int summary)
        {
            summary = a + int.Parse(b);
        }

        public int pow(int number, int power)
        {
            if (power < 2)
                return number;

            return pow(number, power - 1) * number;
        }
        // pow(3, 4)
        // pow(3, 3) * 3
        // pow(3, 2) * 3 * 3
        // pow(3, 1) * 3 * 3 * 3
        // 3 * 3 * 3 * 3 = 81
    }

    public static class Extension
    {
        public static bool IsThereSpace(this string input)
        {
            return input.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string input)
        {
            string[] splitted = input.Split(" ");
            return string.Join("", splitted);
        }
        public static string MakeUpperCase(this string input)
        {
            return input.ToUpper();
        }
        public static int[] SortArray(this int[] input)
        {
            Array.Sort(input);
            return input;
        }
        public static void PrintOnScreen(this int[] input)
        {
            foreach (var num in input)
                System.Console.WriteLine(num);
        }
        public static bool IsEvenNumber(this int input)
        {
            return input % 2 == 0;
        }

        public static char GetFirsChar (this string input)
        {
            return input[0];
        }
    }
}
