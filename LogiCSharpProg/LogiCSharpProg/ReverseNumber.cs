using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiCSharpProg
{
    internal class ReverseNumber
    {
        // Creating Method to Reverse Number
        public void ReverseNum()
        {
            int Number;
            int Reverse = 0;
            int Remainder;
            // Taking Input From User..
            Console.WriteLine("Enter the number You Want to Reverse : ");
            Number = Convert.ToInt32(Console.ReadLine());

            // Define logic to Reverse a Number.
            while (Number != 0)
            {
                Remainder = Number % 10;
                Reverse = (Reverse * 10) + Remainder;
                Number /= 10;
            }
            Console.WriteLine("After Reversed number is : {0} ",Reverse);
        }
    }
}
