using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Duck_No
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int num = number;  int digit; int count = 0;

            while(num > 0)
            {
                digit = num% 10;
                if(digit == 0)
                {
                    count++;
                }

                num=num/10;  
            }

            if (count == 1)
            {
                Console.WriteLine("Duck");
            }
            else
            {
                Console.WriteLine("Not Duck");
            }
        }
    }
}
