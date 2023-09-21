using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//1>A word is alphabetically sorted if all of the letters in it are in consecutive alphabetical order.
//Some examples of alphabetically sorted words: abhors (a is before b, b is before h, h is before o, etc.), ghost, accent, hoop.
//Create a function that takes in a sentence as input and returns true if there is at least one alphabetically sorted word inside that has a minimum length of 3.

namespace Practice_Program
{
    internal class JISA1
    {

        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            bool result =SortedWord(str);

            Console.WriteLine(result);

        }
        static bool SortedWord(string str)
        {
           
            string[] arr = str.Split(' ');

            bool result = true;
            for (int i = 0; i < arr.Length; i++)
            {
                result = true;
                if (arr[i].Length > 2 )
                {
                    
                    char[] arr2 = arr[i].ToCharArray();

                    for (int j = 0; j < arr2.Length-1; j++)
                    {
                        if (arr2[j] > arr2[j + 1])
                        {
                            result = false;
                          
                        }
                    }
                    if (result == true)
                    {
                        return true;
                    }
                }
            }
            return result;
        }
    }
}
