using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class CouponNumbers
    {
        public void Coupon()
        {
            Console.WriteLine("Enter the Number of Unique Coupons That You Want\n");
            int num = Convert.ToInt32(Console.ReadLine());
            HashSet<int> numbers = new HashSet<int>();
            bool flag = true;
            int count = 0;
            Random random = new Random();
            while (flag)
            {
                int coupon = random.Next(1, 1000);
                Console.WriteLine(coupon);
                if (!numbers.Contains(coupon))
                {
                    count++;
                    numbers.Add(coupon);

                }
                if ( count == num) 
                    break;
            }
            Console.Write("Total Random Number Needed to Generate {0} Unique coupons ", num);
            Console.WriteLine(count);
        }
    }
}
