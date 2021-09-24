using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //-- Whole Numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholenumber = 16;
            int wholeNumber = 32;
            long largeWholeNumber = 64;

            int newnumber = oneBytesWorth;

            //-- Decimals
            //-- We put f's at the end of floats to distinguish it as a float
            float floatexample = 1.234456f;
            double doubleexample = 1.23456d;
            decimal decimalexample = 1.23456564m;

            char letter = 'j';

            //-- Operators 
            int numOne = 44;
            int numTwo = 1;

            int sum = numOne + numTwo;
            int diff = numOne + numTwo;
            int prod = numOne + numTwo;
            int quot = numOne / numTwo;
            int remainder = numOne % numTwo;


        }
    }
}
