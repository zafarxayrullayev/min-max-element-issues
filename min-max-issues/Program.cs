using System;
using System.Xml;

namespace min_max_issues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num, limit, max, min;
            //Console.Write("Limit : ");
            //limit = Convert.ToInt32(Console.ReadLine());
            //num = Convert.ToInt32(Console.ReadLine());
            //max = num;
            //min = num;
            //for (int i = 1; i < limit; i++)
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if (min > num)
            //    {
            //        min = num;
            //    }
            //    if (max < num)
            //    {
            //        max = num;
            //    }
            //}

            //Console.WriteLine($"max : {max},    min : {min}");

            //int a, b, s, minS, limit;

            //Console.Write("Limit : ");
            //limit = Convert.ToInt32(Console.ReadLine());
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            //minS = a * b;

            //for (int i = 1; i < limit; i++)
            //{
            //    a = Convert.ToInt32(Console.ReadLine());
            //    b = Convert.ToInt32(Console.ReadLine());
            //    if (minS > a * b)
            //    {
            //        minS = a * b;
            //    }
            //}
            //Console.WriteLine($"minS : {minS}");

            //int limit, num, min, max, minId = 1, maxId = 1;
            //Console.Write("Limit : ");
            //limit = Convert.ToInt32(Console.ReadLine());
            //num = Convert.ToInt32(Console.ReadLine());
            //min = num;
            //max = num;
            //for (int i = 2; i <= limit; i++)
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if (min > num)
            //    {
            //        min = num;
            //        minId = i;
            //    }
            //    if (max < num)
            //    {
            //        max = num;
            //        maxId = i;
            //    }
            //}

            //if (maxId > minId)
            //{
            //    Console.WriteLine($"min element 1 - keladi : {minId}");
            //}
            //else
            //{
            //    Console.WriteLine($"max element 1 - keladi : {maxId}");
            //}

            //int limit, num, min, max, minId = 1, maxId = 1;
            //Console.Write("Limit : ");
            //limit = Convert.ToInt32(Console.ReadLine());
            //num = Convert.ToInt32(Console.ReadLine());
            //min = num;
            //max = num;
            //for (int i = 2; i <= limit; i++)
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if (min >= num)
            //    {
            //        min = num;
            //        minId = i;
            //    }
            //    if (max <= num)
            //    {
            //        max = num;
            //        maxId = i;
            //    }
            //}

            //if (maxId < minId)
            //{
            //    Console.WriteLine($"min element oxirgi keladi : {minId}");
            //}
            //else
            //{
            //    Console.WriteLine($"max element oxirgi keladi : {maxId}");
            //}

            int b, limit, num, min = 0, idMax = 0;
            Console.Write("Limit : ");
            limit = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= limit; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if((num > b) && ((min > num) || (idMax == 0)))
                {
                    min = num;
                    idMax= i;
                }
            }

            Console.WriteLine($"1 - katta element indeksi : {idMax}");
        }
    }
}