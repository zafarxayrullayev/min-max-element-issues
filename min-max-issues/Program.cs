using System;

namespace min_max_issues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, limit, max, min;
            Console.Write("Limit : ");
            limit = Convert.ToInt32(Console.ReadLine());
            num = Convert.ToInt32(Console.ReadLine());
            max = num;
            min = num;
            for (int i = 1; i < limit; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (min > num)
                {
                    min = num;
                }
                if (max < num)
                {
                    max = num;
                }
            }

            Console.WriteLine($"max : {max},    min : {min}");
        }
    }
}