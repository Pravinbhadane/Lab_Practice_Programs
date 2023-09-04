using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Toggle_Char
    {
        static void Main(string[] args)
        {
            char[] arr = new char[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToChar(Console.ReadLine());
            }

              Change_case(arr);

            foreach (char item in arr)
            {
                Console.Write(item + " ");
            }

            Change_case2(arr);

            foreach (char item in arr)
            {
                Console.Write(item+" "); 
            }

        }
        static char[] Change_case(char[] arr)
        {
            for (int i=0; i<arr.Length;i++)
            {
                if (char.IsUpper(arr[i]))
                {
                   arr[i] =char.ToLower(arr[i]);
                }
                else
                {
                  arr[i]=  char.ToUpper(arr[i]);
                }
            }
            return arr;
        }

        static char[] Change_case2(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 'A' && arr[i] <= 'Z')
                {
                    arr[i] = (char)(arr[i] + 32);
                }
                else if (arr[i] >= 'a' && arr[i] <= 'z')
                {
                    arr[i] = (char)(arr[i] - 32);
                }
            }
            return arr;
        }
    }
}
