using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    public class Freq_of_char_word
    {

        static void FreqOfWord(string str)
        {
            string[] arr = str.Split(' ');
            
            foreach (string s in arr)
            {
                int count = 0;
                foreach (string item in arr)
                {
                    if (s == item) count++;
                }
                Console.WriteLine(s+" = "+count);
            }
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            FreqOfChar(str);
            Console.WriteLine();
            Console.WriteLine();
            FreqOfWord(str);
        }

       static void FreqOfChar(string str)
        {
            char max = str[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > max) max= str[i];
            }
                int[] freq = new int[max+1];

         for (int i = 0; i < str.Length; i++)
            {
                freq[str[i]]++;
            }

            Dictionary<char,int> map = new Dictionary<char,int>();
            for (int i = 0;i < str.Length; i++)
            {
               
                map.Add(str[i],freq[str[i]]); 
            }

            foreach(var item in map)
            {
                Console.WriteLine(item.Key+" "+ item.Value);
            }
        }
    }
}
