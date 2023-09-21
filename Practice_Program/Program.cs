//Write a program to input a number and check whether it is greater than 5 or not.

public class Program
{
    static void Main(string[] args)
    {
        //int number = Convert.ToInt32(Console.ReadLine());
        //int n = 5;

        //if(number > n)
        //{
        //    Console.WriteLine("Number is greater than 5");
        //}
        //else if (number < n)
        //{
        //    Console.WriteLine("Number is less than 5");
        //}
        //else Console.WriteLine("Number is 5");

        string str = Console.ReadLine();
        str = str.ToLower();

        int wovels = 0; int cons = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 'a' && str[i] <= 'z')
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    wovels++;
                }
                else
                {
                    cons++;
                }
            }
        }
        Console.WriteLine($"wovels= {wovels} cosonants= {cons}");


    }
}
