using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiCSharpProg
{
    internal class FibonacciSeries
    {

        // sum of previous  two number is next term in Fabonacci Series... 
        public void calcFibonacciSeries()
        {    
            //Taking Variable Num1,Num2 ,num3 to store fabonacci series
            int num1 =0;
            int num2 =1;
            int num3;

            // Taking Input from User of Length of Fabonacci Series...
            Console.Write("Enter The Nth Length of Fabonacci Series : ");
            int LengthOfFabonacci =Convert.ToInt32(Console.ReadLine());  // Storing Length of Fabonacci Series...

            //printing first & Second term of Fabonacci Series
            Console.Write("Fabonacci series of {0}th lengths are {1},{2}",LengthOfFabonacci,num1,num2);

            // Defing Logic For Loop to get the Fabonacci Series..
            for (int i = 2; i < LengthOfFabonacci; i++)
            {
                num3 = num1 + num2;

                //printing term of fabonacci series from 3 to nth Length Enter by User..
                Console.Write(","+num3 );
                num1 = num2;
                num2 = num3;
            }
           



        }

    }
}
