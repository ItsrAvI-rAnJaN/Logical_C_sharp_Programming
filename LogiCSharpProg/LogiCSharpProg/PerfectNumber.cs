using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiCSharpProg
{
    internal class PerfectNumber
    {

        // The Number is Equal to The Sum of its Divisor is Perfect number (Exceuding Number itself)
        public void CheckPerfectNo()
        {
            int Sum = 0; //taking varible where we can store sum of divisor of number

            //Taking Input Number From User to Check Perfert or not
            Console.Write("Enter The Number You Want to Check Perfect or Not : ");
            int Number =Convert.ToInt32(Console.ReadLine()); // Storing Number in Number Variable Enter By User & Convert Into integer

            // define logic For Loop to get Sum of its Divisor of Number
            for (int i = 1; i < Number; i++)
            {
                if (Number%i == 0)
                {
                    Sum=Sum +i;
                }
                   
            }
            // Using if else Block to Check & Print Number is Perfect or Not
            if (Sum == Number)   
            {
                Console.WriteLine("The Number You Enter {0} is a Perfect Number",Number);
            }
            else
            {
                Console.WriteLine("The Number You Enter {0} is Not a Perfect Number",Number);
            }


        }
    }
}
