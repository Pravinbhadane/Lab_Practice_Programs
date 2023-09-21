using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
                    //Given a string, create a function to reverse the case. 
                    //All lower-cased letters should be upper-cased, and vice versa.
                        //Examples
                        //reverseCase("Happy Birthday") ➞ "hAPPY Birthday"
                        //reverseCase("MANY THANKS") ➞ "many thanks"
                        //reverseCase("sPoNtAnEoUs") ➞ "SpOnTaNeOuS"
    internal class JISA3
    {


        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = ConvertToUpperLower(input);


            Console.WriteLine(result);

        }
        static string ConvertToUpperLower(string str)
        {

            string str2 = "";

            foreach (char c in str)
            {
                if (c >= 'a' && c <= 'z')   str2 += (char)(c - 32);

                else if (c >= 'A' && c <= 'Z')    str2 += (char)(c + 32);

                else   str2 += c;
            }

            return str2;
        }
    }
}
