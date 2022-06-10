using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogiCSharpProg
{
    internal class CouponNumber
    {
        // Creating Method for Coupons..
       public void CouponNum()
        {
            // Taking Input From User..
            Console.Write("\nEnter the Number of Coupons : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            string Coupons = string.Empty;
            while (Number > 0)
            {
                int random = new Random().Next(1, 100);
                Coupons += random;
                Number--;
            }
            Console.WriteLine("Your coupon number : {0}",Coupons);

        }
    }
}
