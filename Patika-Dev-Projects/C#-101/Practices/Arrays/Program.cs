using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array Declaring and initializing
            string[] colors = new string[5];

            string[] animals = {"Cat", "Dog", "Bird", "Monkey"};

            int[] countofLikes;
            countofLikes = new int[5];

            // Initializing new values to arrays and accessing arrays

            colors[0] = "Blue";
            countofLikes[3] = 10;

            Console.WriteLine(animals[1]);
            Console.WriteLine(countofLikes[3]);
            Console.WriteLine(colors[0]);

            // Using arrays inside loops
            // Arithmetic mean of n integers received from user

            Console.WriteLine("How many number you want to enter ? ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] arrayOfNums = new int[arrayLength];
            
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Please enter {i + 1}. number : ");
                arrayOfNums[i] = int.Parse(Console.ReadLine);
            }

            int sum = 0;
            foreach (var num in arrayOfNums)
                sum += num;

            Console.WriteLine($"Arithmetic mean : {sum/arrayLength}");
            

            #region Array Methods

                int[] numArray = { 23, 12, 4, 86, 72, 3, 11, 17 };

                // non-sorted array
                foreach (var num in numArray)
                    System.Console.WriteLine(num);

                // sorted array
                Array.Sort(numArray);

                foreach (var num in numArray)
                    System.Console.WriteLine(num);

                // Clear
                // Delete 2 element after 2.index inside numArray
                Array.Clear(numArray, 2, 2);

                foreach (var num in numArray)
                    System.Console.WriteLine(num);

                // Reverse
                Array.Reverse(numArray);

                foreach (var num in numArray)
                    System.Console.WriteLine(num);

                // IndexOf
                System.Console.WriteLine(Array.IndexOf(numArray, 23));
                
                // Resize
                Array.Resize<int>(ref numArray, 9);
                numArray[8] = 99;
                
                foreach (var num in numArray)
                    System.Console.WriteLine(num);
                    
            #endregion
        }
    }
}
