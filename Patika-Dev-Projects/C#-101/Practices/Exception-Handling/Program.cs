using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     Console.WriteLine("Write some number");
            //     int num = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine($"Number you've passed is = {num}");
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine($"Hata : {ex.Message.ToString()}");
            // }
            // finally
            // {
            //     System.Console.WriteLine("Process Completed!");
            // }

            try
            {
                // int a = int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("you entered empty value");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine("Data type is not matching");
                System.Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                System.Console.WriteLine("Number you entered is too low or too high.");
                System.Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("proces successfully completed.");
            }
        }
    }
}
