using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 10, y = 20, z = 30;

            string name = "Chirag";
            char letter = 'a';

            Console.Write("Your name is ");
            Console.Write(name);

            System.Console.WriteLine();
            Console.WriteLine(letter);

            //Converting Strings to Numeric Data Types
            string textAge = "-22";
            int age = Convert.ToInt32(textAge);  
            Console.WriteLine(age);

            //displaying the range of int
            System.Console.WriteLine(int.MinValue);
            System.Console.WriteLine(int.MaxValue);

            string textbigNumber = "7000000";
            long bigNumber = Convert.ToInt64(textbigNumber); 
            Console.WriteLine(bigNumber);

            //displaying the range of long
            System.Console.WriteLine(long.MinValue);
            System.Console.WriteLine(long.MaxValue);

            string textnegative= "-77.2";
            double negative = Convert.ToDouble(textnegative);
            Console.WriteLine(negative);

            //displaying the range of double
            System.Console.WriteLine(double.MinValue);
            System.Console.WriteLine(double.MaxValue);

            string textprecision = "5.000001";
            float precision = Convert.ToSingle(textprecision);
            Console.WriteLine(precision);

            //displaying the range of Float
            System.Console.WriteLine(float.MinValue);
            System.Console.WriteLine(float.MaxValue);

            string textMoney = "17.88";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);

            //displaying the range of Decimal
            System.Console.WriteLine(decimal.MinValue);
            System.Console.WriteLine(decimal.MaxValue);
        }
    }
}