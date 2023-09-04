//Write a program to input a number and check whether it is greater than 5 or not.

public class Program
{
    static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        int n = 5;

        if(number > n)
        {
            Console.WriteLine("Number is greater than 5");
        }
        else if (number < n)
        {
            Console.WriteLine("Number is less than 5");
        }
        else Console.WriteLine("Number is 5");
    }
}