using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _03_Operators
{
    [TestClass]
    public class Operators
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Conversion
            //Casting
            //type name = (castType)value
            int five = 5;
            double doublefive = (double)five;
            Console.WriteLine(doublefive);

            char a = 'a';
            int valueA = (int)a;
            Console.WriteLine(valueA);
            Console.WriteLine(a);

            //string myString = "This is a string.";
            //byte myByte = (byte)myString

            decimal myMoney = 5.97m;
            int intMoney = (int)myMoney; //5

            //Conversion 
            //Type = Convert.toType(value)

            int intfive = 5;
            decimal decimalfive = Convert.ToDecimal(five);

            decimal decimalTwo = 2.55m;
            int intTwo = Convert.ToInt32(decimalTwo); //3

            //Parsing 
            //type name =type.parse(string) 
            string decimalString = "5.6987";
            decimal decimalValue = decimal.Parse(decimalString);
            Console.WriteLine(decimalString);


            //Comparison Operators
            Console.WriteLine("Enter you age");
            string agestring = Console.ReadLine();
            int age = int.Parse(agestring);
            Console.WriteLine("Enter in your name");
            string userName = Console.ReadLine();

            bool equals = age == 41;
            Console.WriteLine("User is 41: " + equals); ;
            Console.WriteLine(equals);

            bool notEquals = age != 41;
            Console.WriteLine($"User is not 41: {equals}");
            Console.WriteLine(notEquals);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine("Lists are equal: " + listsAreEqual);

            bool greaterThan = age > 12;
            bool greaterThanOrEqual = age >= 55;
            bool lessThan = age < 1;
            bool lessThanOrEqual = age <= 90;

            int numberOne = 12;
            int numberTwo = 21;
            bool orValue = equals || notEquals;

            bool andValue = equals && notEquals;

            bool tOrT = true || true;
            bool tOrF = true || false;
            bool fOrT = false || true;
            bool fOrF = false || false;

            bool Value = equals && notEquals;

            tOrT = true && true;
            tOrF = true && false;
            fOrT = false && true;
            fOrF = false && false;

            //&& - both sides of the comparison have to be true in order to deliver a true bool
            int x = 13;
            bool test = x < 44 && x > 10;
            Console.WriteLine(test);

            //|| - ONLY one sides of the comparison has to be true in order to deliver a true bool
            int y = 10;
            bool test2 = y > 20 || y < 15; // Is 10 > 20 or is 10 > 15? false OR true
            Console.WriteLine(test2);


            Console.ReadKey();






        }
    }
}
