using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter the Number\n");
            int num = Convert.ToInt32(Console.ReadLine());
            int number = 0;
            while (num > 0)
            {
                int i = num % 10;
                number = number * 10 + i;
                num /= 10;
            }
            Console.WriteLine("The Reverse Of a Given Number is " + number);

        }
    }
}
