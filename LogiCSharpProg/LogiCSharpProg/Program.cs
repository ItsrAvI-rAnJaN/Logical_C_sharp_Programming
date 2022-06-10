using System;

namespace LogiCSharpProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to C# Logical Programming*****\n ");
            Console.WriteLine("Q1.To Print Fibonacci Series ");
            Console.WriteLine("Q2.Check The Number Is Perfect or Not");
            Console.WriteLine("Q3.Check Number Is Prime or Not");
            Console.WriteLine("Q4. Reverse a Number");
            Console.WriteLine("######################################");

            // Taking Input From User of Question Number..
            Console.Write("\n->Enter The Choice of Question Number : ");

            // Storing The input Fom User in Choice Varible & Convert Into Integer..
            int Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                // Creating Object
                // Calling Method
                case 1:
                    FibonacciSeries objfibonacci = new FibonacciSeries();
                    objfibonacci.calcFibonacciSeries();
                    break;
                case 2:
                    PerfectNumber objperfectno = new PerfectNumber();
                    objperfectno.CheckPerfectNo();
                    break;
                case 3:
                    PrimeNumber objprimeno = new PrimeNumber();
                    objprimeno.CheckPrimeNo();
                    break;
                case 4:
                    ReverseNumber objreverseno = new ReverseNumber();
                    objreverseno.ReverseNum();
                    break;



            }
            Console.ReadKey();
        }
    }
}