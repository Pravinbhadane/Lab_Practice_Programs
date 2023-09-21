using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    public class Jisa6
    {
        static void Main(string[] args)
        {
            string str= Console.ReadLine();

           string result= ReversedString(str);

            Console.WriteLine(result);
        }
        static string ReversedString(string str)
        {
            string[] stringArray = str.Split(' ');

            for (int i = 0; i < stringArray.Length; i++)
            {
                string reverse = "";
                if (stringArray[i].Length % 2== 0)
                {
                    continue;
                }
                else
                {
                    char[] string2 = stringArray[i].ToCharArray();

                    for (int j = string2.Length-1; j >=0; j--)
                    {
                        reverse += string2[j];
                    }
                    stringArray[i]= reverse;
                }
            }
            return string.Join(" ",stringArray);
        }
    }
}
