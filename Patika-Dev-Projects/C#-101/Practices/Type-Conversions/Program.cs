using System;

namespace Type_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine($"d : {d}");

            long h = d;
            Console.WriteLine($"h : {h}");

            float i = h;
            Console.WriteLine($"i : {i}");

            string e = "type";
            char f = 'c';
            object g = e + f + d;
            Console.WriteLine($"g : {g}");

            // Explicit Conversion

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine($"y : {y}");

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine($"t : {t}");

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine($"v : {v}");

            // ToString method

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine($"yy : {yy}");

            string zz = 12.5f.ToString();
            Console.WriteLine($"zz : {zz}");

            string s1 = "10", s2 = "20";
            int num1, num2;
            int sum;

            num1 = Convert.ToInt32(s1);
            num2 = Convert.ToInt32(s2);

            sum = num1 + num2;
            Console.WriteLine($"sum : {sum}");

            // Parse

            string text1 = "10";
            string text2 = "10.25";
            int digit1;
            double doub1;

            digit1 = Int32.Parse(text1);
            doub1 = double.Parse(text2);

            System.Console.WriteLine($"digit1 : {digit1}");
            System.Console.WriteLine($"doub1 : {doub1}");


        }
    }
}
