using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Odd_Even
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];

            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = Convert.ToInt32(Console.ReadLine());
            }

            int[] oddElement = new int[8];
            int[] evenElement = new int[8];

            int i=0, odd = 0 , even = 0 ;
            while(i<arr.Length)
            {
                if (arr[i] % 2 == 0)
                {
                    evenElement[even] = arr[i];
                    i++; even++; 
                }
                else
                {
                    oddElement[odd] = arr[i];
                    i++; odd++;
                }
            }

            foreach (var item in evenElement)
            {
                if (item !=0)
                Console.Write(item+" ");
            }
            Console.WriteLine();

            foreach (var item in oddElement)
            {
                if (item != 0)
                    Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
