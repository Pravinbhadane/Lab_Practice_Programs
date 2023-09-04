using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Sum_of_Facto
    {
        static void Main(string[] args)
        {
            int first = 1; int second = 6;

            int sum = 0; int prevFact=1;

            for(int i=first; i<=second; i++)
            {
                prevFact = prevFact * i;

                sum = sum + prevFact;
            }
            Console.WriteLine(sum);

        }
    }
}
