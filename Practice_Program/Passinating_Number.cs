using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Passinating_Number
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            string result = "";

            for (int i = 1; i <=3; i++)
            {
                result += (number * i);
            }

            Console.WriteLine(result);
            bool passinating = true;
            for (int i = 0; i < result.Length; i++)             
            {
                for (int j = i+1; j < result.Length; j++)
                {
                    if (result[i] == result[j])
                    {
                        passinating = false;
                        break;
                    }
                }
            }

            if(passinating==true)
                Console.WriteLine("Number is Passinating");
            else
                Console.WriteLine("Number is Not Passinating");
        }
    }
}
