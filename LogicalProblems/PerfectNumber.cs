using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PerfectNumber
    {
        public void Perfect()
        {
            Console.WriteLine("enter the number\n");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 1;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                    if (i != number / i)
                        sum += number / i;
                }
                Console.WriteLine(sum + " ");
            }
            if (sum == number)
            {
                Console.WriteLine("It is a perfect number\n");
            }
            else
            {
                Console.WriteLine("It is not a perfect number\n");
            }
        }
    }
}
