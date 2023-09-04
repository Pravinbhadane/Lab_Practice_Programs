using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Alternate_Char
    {
        static void Main(string[] args)
        {
            char[] arr = new char[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToChar(Console.ReadLine());
            }

            Alternate(arr);

            foreach (char item in arr)
            {
                Console.Write(item + " ");
            }

        }
      
        static char[] Alternate(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] >= 'A' && arr[i] <= 'z')
                {
                    if (arr[i] == 'Y' || arr[i] == 'y' || arr[i] == 'Z' || arr[i] == 'z')
                    {
                        arr[i] = (char)(arr[i] - 24);
                    }
                    else  arr[i] = (char)(arr[i] + 2);
                }

            }
            return arr;
        }
    }
}
