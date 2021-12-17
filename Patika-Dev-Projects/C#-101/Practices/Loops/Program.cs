using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Loop
                 Console.Write("Submit a number : ");
                 int iterateAmount = int.Parse(Console.ReadLine());
     
                 for (int i = 0; i < iterateAmount; i++)
                 {
                     if(i % 2 == 1)
                         Console.WriteLine(i);
                 }
     
     
                 // summary of even and odd numbers from 1 to 1000
                 int sumofOdd = 0, sumofEven = 0;
     
                 for (int i = 0; i < 1001; i++)
                 {
                     if (i % 2 == 1)
                         sumofOdd += i;
                     else
                         sumofEven += i;
                     // i % 2 == 0 ? (sumofEven += i) : (sumofOdd += i);
                 }
                 Console.WriteLine($"Sum of odd numbers : {sumofOdd}\nSum of even numbers : {sumofEven}");
     
                 // break, continue
     
                 for (int i = 1; i < 11; i++)
                 {
                     if (i == 4)
                         break;
                         
                     Console.WriteLine(i);
                 }
                 for (int i = 1; i < 11; i++)
                 {
                     if (i == 4)
                         continue;
     
                     Console.WriteLine(i);
                 }
            #endregion

            #region While Foreach
                 Console.Write("Please submit a number : ");
                 int num2 = int.Parse(Console.ReadLine());
                 int iterateVar = 1, sum = 0;

                 while (iterateVar <= num2)
                 {
                     sum += iterateVar;
                     iterateVar++;
                 }
                 Console.WriteLine(sum/num2);

                 // all alphabet chars from 'a' to 'z'
                 char character = 'a';
                 while (character < 'z')
                {
                    Console.WriteLine(character);
                    character++;
                }

                string[] cars = {"BMW", "Ford", "Toyota", "Nissan"};

                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            #endregion
        }
    }
}
