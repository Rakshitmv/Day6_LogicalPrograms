using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class PrimeNumber
    {
        public void Prime()
        {
            bool answer = true;
            Console.WriteLine("Enter the number\n");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) answer = false;
            }
            if (answer)
            {
                Console.WriteLine("It is a prime\n");
            }
            else
            {
                Console.WriteLine("It is not a prime\n");
            }
        }
    }
}
