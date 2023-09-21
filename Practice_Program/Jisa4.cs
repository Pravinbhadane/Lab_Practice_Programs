using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Jisa4
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int num = number; int result=0;

            while(number > 0)
            {
                int rem = number % 10;

                result = result * 10+rem;
                number = number / 10;
            }
           Console.WriteLine(num-result);
        }
    }
}
