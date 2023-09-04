using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class _1st_N_last_3_digit
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            if (str.Length < 3)   throw new Exception("Length is less than 3");
            else
            {
                int sum1 = 0; int sum2 = 0;
                int left = 0, rigth = str.Length - 1;

                while (left < 3)
                {
                    if (str[left] >= '0' && str[left] <= '9' && str[rigth] >= '0' && str[rigth] <= '9')
                    {
                        sum1 = sum1 + Convert.ToInt32(str[left]);
                        sum2 = sum2 + Convert.ToInt32(str[rigth]);

                        left++; rigth--;
                    }
                    else
                    {
                        throw new Exception("String Contains Other than Number");
                       
                    }
                }
                Console.WriteLine(sum1); Console.WriteLine(sum2);
                if (sum1 == sum2)
                {
                    Console.WriteLine("Valid String");
                }
                else
                {
                    throw new Exception("String is Not Valid");
                }
            }
        }
    }
}
