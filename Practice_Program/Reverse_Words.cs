using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Reverse_Words
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string[] arr = s.Split(' ');
            string reverse = "";

            for (int i = 0; i < arr.Length; i++)
            {
                //char[] charArr = arr[i].ToCharArray();

                //for(int j = charArr.Length-1; j >=0; j--)
                //{
                //    Console.Write(charArr[j]);
                //}
                //Console.Write(" ");

                      //-----------------USING SECOND METHOD------------------------
                if (i == 0 || i == arr.Length-1)  
                {
                    reverse = reverse +" "+ arr[i];  // Skeep first and last word and reverse all words in the string
                }
                else
                {
                    string word = arr[i];
                    string result = "";

                    int j = word.Length - 1;

                    while (j >= 0)
                    {
                        result = result + word[j];
                        j--;
                    }
                    reverse = reverse + " " + result;

                }
            }
                 Console.WriteLine(reverse);

        }
    }
}
