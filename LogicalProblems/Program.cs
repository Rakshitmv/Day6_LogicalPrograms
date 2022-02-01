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
                Console.WriteLine("Enter 1: fibonacci series\n" + "Enter 2: Perfect Number\n" + "Enter 3: Prime Number\n" + "Enter 4: Exit\n");
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
