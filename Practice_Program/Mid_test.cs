using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Mid_test
    {
        static void Main(string[] args)
        {
            int j = 2, k = 2;
            Console.WriteLine(j-- - --j - --j + ++k - k-- + (j - k) + --j + j++ - --k + ++k);
            Console.WriteLine("Q2");
            for (int i = 5; i > 0; i--)
            {
                for (int l = 1; l <= i; l++)
                {
                    Console.Write(l + " ");
                }
                Console.WriteLine();
            }

            string str ="Help Others";

            char[] arr = str.ToCharArray();

            string result = "";

            for (int i = arr.Length - 1; i >= 0; i--)
            {

               
                    result = result + arr[i];
                
            }
            Console.WriteLine(result);


            float d = 89.75f;

            double b = d;
            Console.WriteLine(  b);
            short s = (short)d;
            int a = (int)b      ;
            Console.WriteLine(s);
            Console.WriteLine(a);

            int[] arr1 = { 12, 5, 6, 7, 10 };
            int[] arr2 = { 5, 6, 4, 12, 9 };
            

      Dictionary<int,int> map = new Dictionary<int,int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int n = 0; n < arr2.Length; n++)
                {
                    if (arr1[i] == arr2[n])
                    {
                       
                        if (!map.ContainsKey(i)) map.Add(i, arr1[i]);
                    }
                }
            }
            foreach (KeyValuePair<int, int> item in map)
            {
             
                    Console.WriteLine(item.Key + "=" + item.Value);
            }

            foreach (KeyValuePair<int,int> item in map)
            {
                if (item.Value % 2 == 0)
                    Console.WriteLine(item.Key + "=" + item.Value);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string str1 = "java";
            string str2 = "";

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == 'y' || str1[i] == 'z')
                {
                    str2 = str2 + (char)(str1[i] - 24);
                }
                else
                {
                    str2 = str2 + (char)(str1[i] + 2);
                }
            }
            Console.WriteLine(str2);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //E.g.given array { 4,6,12,8,3}      //if array size is odd do not move middle element
            //Output will be { 8,3,12,4,6}

            //e.g given array { 2,7,1,9,5,8}
            //output will be { 9,5,8,2,7,1}

            //Q10

            int [] arr5 = { 4, 6, 12, 8, 3 };
        int half = arr1.Length-1; int start = 0;

            while (half < arr1.Length-1)
            {
                int temp;
                if (arr1.Length % 2 != 0)
                {
                     temp = arr1[half + 1];
                    arr1[half + 1] = arr1[start];
                    arr1[start] = temp;
                }
                else
                {
                     temp = arr1[half];
                    arr1[half] = arr1[start];
                    arr1[start] = temp;
                }
            }

            foreach (var item in arr1)
            {
                Console.Write(" "+item);
            }
            Console.WriteLine(); 
            Console.WriteLine();

            Console.WriteLine("Most repeated word");
            Console.WriteLine();
            string str3 = "india is the best country and india is great country";
            MostRepeatedWord(str3);

        }

        static void MostRepeatedWord(string str)
        {
            string[] arr = str.Split(' ');

            int max = 0; string word = "";
            foreach (string s in arr)
            {
                int count = 0;
                foreach (string item in arr)
                {
                    if (s == item) count++;
                }
                if(count > max)
                {
                    max = count;
                    word = s;
                }

            }
            Console.WriteLine(word+" "+max);

        }
    }
}
