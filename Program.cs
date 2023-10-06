//Написать программу, которая принимает число и выдает сумму цифр в числе

using System;

namespace SummaOfNumbersCollection
{
    class Program
    {
        static int GetSum(int num)
        {
            int i = 1;
            int sum = 0;

            while (i <= num)
            {
                sum += i;
                i++;
            }
            return sum;
        }
        static public void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = GetSum(num);
            Console.WriteLine(result);
        }
    }
}
