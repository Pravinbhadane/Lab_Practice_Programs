using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    //internal class JISA2
    //{
    //    static void Main(string[] args)
    //    {
    //        string str = Console.ReadLine();

    //        char[] ch = str.ToCharArray();

    //        char[] result = new char[ch.Length];
    //        for (int i = 0; i < ch.Length; i++)
    //        {
    //            if (ch[i]==' ')
    //            {
    //                result[i] = ' ';
    //            }
    //        }
    //        int j=result.Length-1;

    //        for(int i = 0; i < ch.Length;i++)
    //        {
    //            if(ch[i]!=' ')
    //            {
    //                if (result[j] == ' ')
    //                {
    //                    j--;
    //                }
    //            }
    //            result[j] = ch[i];
    //            j--;
    //        }
    //        string rev="";
    //        int k = 0;
    //        for(int i = 0;i < ch.Length;i++)
    //        {
    //            char c = ch[i];
    //            if(char.IsUpper(c))
    //            {
    //                rev = rev + ((char)(result[k] -32));
    //                k++;
    //            }
    //            else if(char.IsLower(c))
    //            {
    //                rev = rev + ((char)(result[k] +32));
    //                k++;
    //            }
    //            else
    //            {
    //                rev = rev + result[k];
    //                k++;
    //            }
    //        }
    //        Console.WriteLine(rev);
    //    }
    //}
    internal class JISA2
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            char[] ch = str.ToCharArray();

            char[] result = new char[ch.Length];
  

            int j = ch.Length - 1;

            for (int i = 0; i < ch.Length; i++)   // UPPER lower     "REWOL reppu"

            {
                if (ch[i] == ' ') 
                {
                    result[i] = ' ';     
                }
                else
                {
                    while (result[j] == ' ')
                    {
                        j--;
                    }
                    result[j] = ch[i];
                    j--;
                }
            }


            for (int i = 0; i < ch.Length; i++)
            {
                char c = ch[i];                                     // U P P E R  _ l o w e r
                if (char.IsUpper(c))
                {                                                   //[ r,e , w, o, l,_ ,R,E,P,P,U] result
                    result[i] = char.ToUpper(result[i]);
                }
                else if (char.IsLower(c))
                {
                    result[i] = char.ToLower(result[i]);
                }
            }

            string rev = new string(result);
            Console.WriteLine(rev);
        }
    }
}
