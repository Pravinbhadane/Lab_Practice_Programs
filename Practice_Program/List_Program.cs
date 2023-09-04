using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class List_Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Red");
            list.Add("Green");
            list.Add("Red");
            list.Add("Blue");

          Dictionary<string,int> result = new Dictionary<string,int>();

            foreach (var item in list)
            {
                int count = 0;
                foreach (var i in list)
                {
                    if (item == i)
                    {
                        count++;
                        
                    }
                }
                if (!result.ContainsKey(item))
                {
                    result.Add(item, count);
                }
            }
            foreach (KeyValuePair<string,int> j in result )
            {
                Console.WriteLine($"{j.Key} = {j.Value}");
            }
        }
    }

}
