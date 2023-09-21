using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Program
{
    internal class Jisa7
    {
        public static string[] LeftRotations(string input)
        {
            int length = input.Length;
            string[] rotations = new string[length];

            for (int i = 0; i < length; i++)
            {
                rotations[i] = input.Substring(i) + input.Substring(0, i);
            }

            return rotations;
        }
        public static string[] RightRotations(string input)
        {
            int length = input.Length;
            string[] rotations = new string[length];

            for (int i = 0; i < length; i++)
            {
                rotations[i] = input.Substring(length - i) + input.Substring(0, length - i);
            }

            return rotations;
        }
        public static void Main(string[] args)
        {
            string input = "abcdef";

            string[] leftRotations = LeftRotations(input);
            Console.WriteLine("Left Rotations:");
            foreach (string rotation in leftRotations)
            {
                Console.Write(rotation + " ");
            }
            Console.WriteLine();

            string[] rightRotations = RightRotations(input);
            Console.WriteLine("\nRight Rotations:");
            foreach (string rotation in rightRotations)
            {
                Console.WriteLine(rotation);
            }
        }
    }
}
