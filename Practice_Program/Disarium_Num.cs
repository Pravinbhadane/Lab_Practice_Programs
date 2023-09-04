using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Disarium_Num
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int num = number; int count = 0;
            int digit; int sum = 0;

          
            while(num > 0)
            {
              
                count++;
                num/=10;
            }
           num = number;
            Console.WriteLine(count);

            while (num > 0)
            {
                digit = num % 10;

               sum = sum+ Digit_Power(digit, count);
                num/=10;
                count--;
            }
            Console.WriteLine(sum);
            Console.WriteLine(count);

            if (sum == number)
            {
                Console.WriteLine("Number Is Disarium");
            }
            else
            {
                Console.WriteLine("Number is Not  Disarium");
            }
            
        }

        static int Digit_Power(int digit, int count)
        {
            int p = 1;
            for(int i= 1; i <= count; i++)
            {
                p = p * digit;
            }
            return p;
        }
    }
}
