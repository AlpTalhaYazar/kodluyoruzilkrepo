using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assignment and Compound Assignment

            int x = 3;
            int y = 3;

            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            // Logical Operators
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect!");
            
            if (isSuccess || isCompleted)
                Console.WriteLine("Great!");

            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine!");

            // Comparison operators
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;
            bool result = a < b;

            Console.WriteLine(result);
            result = a > b;
            Console.WriteLine(result);
            result = a >= b;
            Console.WriteLine(result);
            result = a == b;
            Console.WriteLine(result);
            result = a != b;
            Console.WriteLine(result);
            

            // Arithmetic operators
            // ++(increment) --(decrement) +(plus) -(minus) 
            // *(multiplication) /(division) %(remainder) +(addition) -(subtraction) 
            
            int num1 = 10;
            int num2 = 5;
            int result2 = num1/num2;
            Console.WriteLine(result2);
            result2 = num1 * num2;
            Console.WriteLine(result2);
            result2 = num1 + num2;
            Console.WriteLine(result2);
            result2 += num1++;
            Console.WriteLine(result2);
            result2 = 20 % 3;
            Console.WriteLine(result2);
        }
    }
}
