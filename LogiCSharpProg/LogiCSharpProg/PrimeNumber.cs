using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiCSharpProg
{
    internal class PrimeNumber
    {
        // Create Method to Check Prime Number.
        public void CheckPrimeNo()
        {
            Console.Write("Enter the Number You Want to Check Prime or Not ? : ");
            // Taking Input From User..
            int Number = Convert.ToInt32(Console.ReadLine());
            int Flag = 0;


            // for Number 2 It is only Even Prime Number
            if (Number == 2)
            {
                Console.WriteLine("The number You Enter is a Prime Number");
            }

            //Prime Number Check Prime or Not Greater than 2.
            if (Number > 2)
            {
                for (int i = 2; i < Number / 2; i++)
                {
                    if (Number % i == 0)
                    {
                        Flag = 1;
                        break;
                    }
                }

                // Printing Number is Prime or Not.
                if (Flag == 1)
                {
                    Console.WriteLine("The Number You Enter is  Not a Prime Number");
                }
                else
                {
                    Console.WriteLine("The Number You Enter is a Prime Number");
                }
            }
            else
            {
                Console.WriteLine("You Enter Number Less Than 2");
            }
        }
    }
}