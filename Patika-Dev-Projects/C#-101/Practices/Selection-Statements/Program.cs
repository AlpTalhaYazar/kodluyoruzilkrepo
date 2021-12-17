using System;

namespace Selection_Statements
{
    class Program
    {
        static void Main(string[] args)
        {

            #region if-elseif-tenaryif
            int time = DateTime.Now.Hour;

            if (time >= 6 && time < 11)
                Console.WriteLine("Good morning");
            else if (time <= 18)
                Console.WriteLine("have a good day");
            else
                Console.WriteLine("Good evening/night");

            string result = time <= 18 ? "Have a good day" : "Good evening";

            result = time >= 6 && time < 11 ? "Good morning" : time <= 18 ? "have a good day" : "Good evening";

            System.Console.WriteLine(result);
            #endregion

            #region switch-case
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                default:
                    Console.WriteLine("Wrong month");
                    break;
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("fall");
                    break;
                default:
                    Console.WriteLine("no such thing");
                    break;
            }
            #endregion
        }
    }
}
