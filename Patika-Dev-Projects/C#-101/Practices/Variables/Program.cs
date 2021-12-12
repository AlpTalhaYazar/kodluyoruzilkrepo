using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
#region Integers
                 byte b = 5;             // 1 byte
                 sbyte c = 5;            // 1 byte
     
                 short s = 5;            // 2 byte
                 ushort us = 5;          // 2 byte
                 
                 int i = 2;              // 4 byte
                 uint ui = 2u;            // 4 byte
                 long l = 4L;             // 8 byte
                 ulong ul = 4uL;           // 8 byte
#endregion

#region Real Numbers
                 float fl = 5f;            // 4 byte
                 double d = 5d;           // 8 byte
                 decimal de = 5m;         // 16 byte
#endregion

            // Unicode characters
            char ch = 'z';          // 2 byte
            string str = "trial";

            // Logical value
            bool b1 = true;         // 1 byte

            // Represents date and time
            DateTime dt = DateTime.Now;
            System.Console.WriteLine(dt);

            // Base type of all other types.
            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.5d;

#region String
                 string str1 = string.Empty;
                 str1 = "Hello";
                 string first = "Hello";
                 string second = "World";
                 string full = $"{first} {second}"; // String interpolation

                 Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", second, dt.DayOfWeek, dt);                 // Composite formatting:
#endregion

#region Integer Defining
                int i1 = 5;
                int i2 = 3;
                int i3 = i1 + i2;
#endregion

#region Boolean
                bool bl1 = true;
                bool bl2 = 10 > 1;
#endregion

#region Casting and type conversions
/*
 * Implicit Conversion From  =>  To
 *  sbyte    =>  short, int, long, float, double, decimal
 *  byte     =>  short, ushort, int, uint, long, ulong, float, double, decimal
 *  short    =>  int, long, float, double, or decimal
 *  ushort   =>  int, uint, long, ulong, float, double, or decimal
 *  int      =>  long, float, double, or decimal.
 *  uint     =>  long, ulong, float, double, or decimal
 *  long     =>  float, double, or decimal
 *  ulong    =>  float, double, or decimal
 *  char     =>  ushort, int, uint, long, ulong, float, double, or decimal
 *  float    =>  Double
 */
                // Implicit conversions
                // A long can hold any value
                // an int can hold, and more!
                int num = 2147483647;
                long bigNum = num;

                
                // Explicit conversions
                double ca1 = 1234.7;
                int ca2;
                ca2 = (int)ca1;

                // Type Conversion Methods
                // It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):

                int myInt = 10;
                double myDouble = 5.25;
                bool myBool = true;

                Console.WriteLine(Convert.ToString(myInt));    // convert int to string
                Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
                Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
                Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
#endregion

#region Date Time
                // 2015 is year, 12 is month, 25 is day
                DateTime date1 = new DateTime(2015, 12, 25);
                Console.WriteLine(date1.ToString()); // 12/25/2015 12:00:00 AM
                
                // 2015 - year, 12 - month, 25 – day, 10 – hour, 30 – minute, 50 - second
                DateTime date2 = new DateTime(2012, 12, 25, 10, 30, 50);
                Console.WriteLine(date1.ToString());// 12/25/2015 10:30:00 AM }

                // Define an uninitialized date.
                Console.Write(DateTime.MinValue); // 1/1/0001 12:00:00 AM

                // Define an uninitialized date.
                Console.Write(DateTime.MaxValue); // 12/31/9999 11:59:59 PM

                // Creating TimeSpan object of one month(as 30 days)  
                System.TimeSpan duration = new System.TimeSpan(30, 0, 0, 0);  
                System.DateTime newDate1 = DateTime.Now.Add(duration);  
                System.Console.WriteLine(newDate1); // 1/19/2016 11:47:52 AM  
                
                // Adding days to a date  
                DateTime today = DateTime.Now; // 12/20/2015 11:48:09 AM  
                DateTime newDate2 = today.AddDays(30); // Adding one month(as 30 days)  
                Console.WriteLine(newDate2); // 1/19/2016 11:48:09 AM  
                
                // Parsing  
                string dateString = "Wed Dec 30, 2015";  
                DateTime dateTime12 = DateTime.Parse(dateString); // 12/30/2015 12:00:00 AM  
                
                // Date Difference  
                System.DateTime date3 = new System.DateTime(2015, 3, 10, 2, 15, 10);  
                System.DateTime date4 = new System.DateTime(2015, 7, 15, 6, 30, 20);  
                System.DateTime date5 = new System.DateTime(2015, 12, 28, 10, 45, 30);  
                
                // diff1 gets 127 days, 04 hours, 15 minutes and 10 seconds.  
                System.TimeSpan diff1 = date4.Subtract(date1); // 127.04:15:10  
                // date6 gets 8/23/2015 6:30:20 AM  
                System.DateTime date6 = date5.Subtract(diff1);  
                // diff2 gets 166 days 4 hours, 15 minutes and 10 seconds.  
                System.TimeSpan diff2 = date5 - date4; //166.04:15:10  
                // date7 gets 3/10/2015 2:15:10 AM  
                System.DateTime date7 = date4 - diff1;  
                
                // Universal Time  
                DateTime dateObj = new DateTime(2015, 12, 20, 10, 20, 30);  
                Console.WriteLine("mans" + dateObj.ToUniversalTime()); // 12/20/2015 4:50:30 AM
#endregion

        }
    }
}
