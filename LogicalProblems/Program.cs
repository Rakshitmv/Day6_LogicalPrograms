using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter 1: fibonacci series\n" + "Enter 2: Perfect Number\n" + "Enter 3: Prime Number\n" + "Enter 4: Reverse Number\n" + "Enter 5: To generate Coupons\n" + "Enter 6: Stop Watch\n" + "Enter 7: Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                   case 1:
                        Fibonacci fibonacci = new Fibonacci();
                        fibonacci.CheckFibonacci();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.Perfect();
                        break;
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();    
                        primeNumber.Prime();
                        break;
                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.Reverse();
                        break;
                    case 5:
                        CouponNumbers couponNumbers = new CouponNumbers();
                        couponNumbers.Coupon();
                        break;
                    case 6:
                        StopWatch stopWatch = new StopWatch();  
                        stopWatch.Watch();
                        break;
                    case 7:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Please enter the correct option\n");
                        break;
                }



            }
            

        }
    }
}
