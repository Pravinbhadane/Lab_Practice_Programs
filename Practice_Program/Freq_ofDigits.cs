using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Freq_ofDigits
    {
        static void Main(string[] args)
        {
            int number = 12233455;

            int num = number;

            for (int i = 0; i <= 9; i++)
            {
                int digit; int count = 0;
                while(num > 0)
                {
                    digit = num % 10;
                    if (digit == i)
                    {
                        count++;
                    }
                    num /= 10;
                }
                num = number;
                Console.WriteLine($"{i} = {count}");
            }
        }
    }
}
