﻿using System;
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
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            string textbigNumber = "7000000";
            long bigNumber = Convert.ToInt64(textbigNumber); 
            Console.WriteLine(bigNumber);

            //displaying the range of long
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            string textnegative= "-77.2";
            double negative = Convert.ToDouble(textnegative);
            Console.WriteLine(negative);

            //displaying the range of double
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            string textprecision = "5.000001";
            float precision = Convert.ToSingle(textprecision);
            Console.WriteLine(precision);

            //displaying the range of Float
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            string textMoney = "17.88";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);

            //displaying the range of Decimal
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);


        
             
        // Booleans
            bool value = true; 
            bool isMale = true;
            Console.WriteLine(isMale);  // Prints 'True'

            isMale = false; 
            Console.WriteLine(isMale);  // Prints 'False'

        //Operators


            age++;
            age = age + 1;
            age += 10;
            Console.WriteLine(age);
            age--;
            Console.WriteLine(age);

            double age1 = 23; 
            // + - /
            age1 /= 10; // 2.3 -> 2
            System.Console.WriteLine(age1);

            string nam1 = "Chirag";
            nam1+= " is programming!";

            name += " is gonna become a goat at C#";
            System.Console.WriteLine(name);

            Console.WriteLine(nam1);

            char ch = 'a';
            ch += 'f';
            System.Console.WriteLine(ch);

            int c = 0;
            System.Console.WriteLine(++c);
            System.Console.WriteLine(c++);

            double firstNum = 10;
            double secondNum = 3;

            System.Console.WriteLine(firstNum / secondNum); //division
            System.Console.WriteLine(firstNum % secondNum); //remainder

        //Variables
            var age4 = 23;
            Console.WriteLine(age4);

            var negative1 = -55.2; 
            System.Console.WriteLine(negative1);

            var precision2 = 6.0001;
            System.Console.WriteLine(precision2);

            var money2 = 15.88M;
            System.Console.WriteLine(money2);

            var name2  = "Chirag";
            System.Console.WriteLine(name2);


            var letter2 =  'f';
            System.Console.WriteLine(letter2);

            //using var too much doesn't make sense for good code readability, using the actual 
            //datatypes is always better


            //Const keyword

            const int vat = 20; //declaring the constant, and the value doesn't change
            const double percentVAT = vat / 100D;
            System.Console.WriteLine(vat);

            int balance  = 1000;
            System.Console.WriteLine(balance * percentVAT);

            const string version = "v1.0";
        }
    }
}