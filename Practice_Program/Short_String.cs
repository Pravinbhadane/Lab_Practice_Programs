using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Short_String
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string[] arr = s.Split(' ');

            string result = "";

            for(int i=0; i<arr.Length; i++)
            {
                if(i == arr.Length - 1)
                {
                    result = result+arr[i]+" ";
                }
                else
                {
                    char[] charArr = arr[i].ToCharArray();

                    for (int j = 0; j < 1; j++)
                    {

                        result = result + (charArr[j]) + ".";
                    }
                }
              
            }

            Console.WriteLine(ToTitleCase(result));
        }
        public static string ToTitleCase(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }
    }
}
