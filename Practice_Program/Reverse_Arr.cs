using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Reverse_Arr
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] =Convert.ToInt32(Console.ReadLine());
            }

            Reverse_Arr1(arr);

            foreach (var item in arr)
            {
                Console.Write(item+" ");
            }
        }
        static int[] Reverse_Arr1(int[] arr)
        {
            int left = 0; int right = arr.Length-1;

            while(left < right)
            {
                int temp= arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
            }
            return arr;
        }
    }
}
