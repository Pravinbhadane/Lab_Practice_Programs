using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Case_Change
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = "";

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                    result += char.ToLower(c);
                else if (char.IsLower(c))
                    result += char.ToUpper(c);
                else
                    result += c;
            }
            Console.WriteLine("Method 1= "+result);

            Console.WriteLine("Method 2= " + ConvertToUpperLower(input)); 
        }

        static string ConvertToUpperLower(string str)
        {
            
            string str2 = "";

            foreach (char c in str)
            {
                if (c >= 'a' && c <= 'z')
                    str2 += (char)(c - 32);
                else if (c >= 'A' && c <= 'Z')
                    str2 += (char)(c + 32);
                else
                    str2 += c;
            }

            return str2;
        }
    }
}
