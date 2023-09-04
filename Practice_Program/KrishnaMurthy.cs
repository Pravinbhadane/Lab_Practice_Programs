using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    public class KrishnaMurthy
    {
        static void Main(string[] args)
        {
            int number = 145;
            int num = number; int result = 0; 

            while (num > 0)
            {
                int digit = number % 10;

                result = SumOfFact(digit);

            }


            if(number == result)
            {
                Console.WriteLine("Number Is Krishnamurthy");
            }
            else Console.WriteLine("Number Is Not Krishnamurthy");


        }
        static int SumOfFact(int digit)
        {
            int prevFact = 1;

            for (int i = 1; i <= digit; i++)
            {
                prevFact = prevFact * i;

            }
            return prevFact;

        }
    }
}
