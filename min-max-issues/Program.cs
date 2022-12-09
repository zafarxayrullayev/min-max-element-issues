using System;
using System.Collections.Generic;
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

            //int b, limit, num, min = 0, idMax = 0;
            //Console.Write("Limit : ");
            //limit = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b = ");
            //b = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= limit; i++)
            //{
            //    num = Convert.ToInt32(Console.ReadLine());
            //    // limit = 4, b = 1, 1 2 3 4
            //    if((num > b) && ((min > num) || (idMax == 0)))
            //    {
            //        min = num;
            //        idMax= i;
            //    }
            //}

            //Console.WriteLine($"1 - katta element indeksi : {idMax}");

            // 14 - misol tugadi 

            //int b, c, limit, max = 0, id = 0, kiritiladiganSon;
            //Console.Write("Limit : ");
            //limit = Convert.ToInt32(Console.ReadLine());
            //Console.Write("b = ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("c = ");
            //c = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= limit; i++)
            //{
            //    kiritiladiganSon = Convert.ToInt32(Console.ReadLine());
            //    if (kiritiladiganSon > b && kiritiladiganSon < c && (max > kiritiladiganSon || id == 0))
            //    {
            //        max = kiritiladiganSon;
            //        id = i;
            //    }
            //}
            // 15 - misol tugadi
            //Console.WriteLine($"tartib raqam : {id}");

            // 8 -->  4 3 2 1 6 7 1 3
            //        1 2 3 4 1 3 4 5

            //int limit, kiritiladiganSon, min = 0, sum = 0, id = 0;
            //Console.Write("Limit : ");
            //limit = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= limit; i++)
            //{
            //    kiritiladiganSon = Convert.ToInt32(Console.ReadLine());
            //    if (kiritiladiganSon < min || id == 0)
            //    {
            //        min = kiritiladiganSon;
            //        id = i;
            //    }
            //}
            // algoritm shunday: bitta elementni tanlab olishim kerak bo'ladi,
            // shu element bilan qolgani solishtiraldi
            //Console.WriteLine($"soni : {id - 1}");

            // 17-misol tugadi


            //int limit, kiritSon, idFirst = 0, idLast = 0, max = 0;
            //Console.Write("Limit : ");
            //limit = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= limit; i++)
            //{
            //    kiritSon = Convert.ToInt32(Console.ReadLine());
            //    if (max < kiritSon || idFirst == 0)
            //    {
            //        max = kiritSon;
            //        idFirst = i;
            //    }
            //    if (max <= kiritSon || idLast == 0)
            //    {
            //        max = kiritSon;
            //        idLast = i;
            //    }
            //}
            //if (idLast - idFirst == 0)
            //{
            //    Console.WriteLine("0");
            //}
            //else
            //{
            //    Console.WriteLine($"soni : {idLast - idFirst - 1}");
            //}

            // 18 - misol tugadi 
            //int limit, kiritSon, id = 0, min = 0, count = 0;
            //Console.Write("Limit : ");
            //limit = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= limit; i++)
            //{
            //    kiritSon = Convert.ToInt32(Console.ReadLine());
            //    if (min >= kiritSon || id == 0)
            //    {
            //        min = kiritSon;
            //        id = i;

            //    }
            //}

            //Console.WriteLine($"soni : {id}");

            //int limit, kiritSon, count = 1, id =0, min;
            //Console.Write("limit : ");
            //limit = Convert.ToInt32(Console.ReadLine());
            //kiritSon = Convert.ToInt32(Console.ReadLine());
            //min = kiritSon;
            //for (int i = 1; i < limit; i++)
            //{
            //    kiritSon = Convert.ToInt32(Console.ReadLine());
            //    if (min > kiritSon)
            //    {
            //        min = kiritSon;
            //        count = 0;
            //    }
            //    if (kiritSon == min)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine($"soni {count}");
            // 19 tugadi


            //int limit, kiritSon, soniMax = 1, soniMin = 1, min, max;
            //Console.Write("limit : ");
            //limit = Convert.ToInt32(Console.ReadLine());
            //kiritSon = Convert.ToInt32(Console.ReadLine());
            //min = kiritSon;
            //max = kiritSon;
            //for (int i = 1; i < limit; i++)
            //{
            //    kiritSon = Convert.ToInt32(Console.ReadLine());
            //    if (min > kiritSon)
            //    {
            //        min = kiritSon;
            //        soniMin = 0;
            //    }
            //    if (min == kiritSon)
            //    {
            //        soniMin++;
            //    }

            //    if (max < kiritSon)
            //    {
            //        max = kiritSon;
            //        soniMax = 0;
            //    }
            //    if (max == kiritSon)
            //    {
            //        soniMax++;
            //    }
            //}

            //Console.WriteLine($"min soni : {soniMin} va max soni : {soniMax}");

            // 20 - tugadi
            //double limit, kiritSon, min, max, sum;
            //Console.Write("limit : ");
            //limit = Convert.ToDouble(Console.ReadLine());
            //kiritSon = Convert.ToDouble(Console.ReadLine());
            //min = kiritSon;
            //max = kiritSon;
            //sum = kiritSon;
            //for (int i = 1; i < limit; i++)
            //{
            //    kiritSon = Convert.ToDouble(Console.ReadLine());
            //    if (min > kiritSon)
            //    {
            //        min = kiritSon;
            //    }
            //    if (max < kiritSon)
            //    {
            //        max = kiritSon;
            //    }

            //    sum += kiritSon;
            //}

            //sum -= (max + min);
            //Console.WriteLine($"o'rta qiymat : {sum / (limit - 2)}");

            //21 - tugadi

            //int limit, kiritSon, min1, min2 = 0;
            //Console.Write("limit : ");
            //limit = Convert.ToInt32(Console.ReadLine());
            //// 6 --> 1 3 2 5 6 9 ==> 1, 2
            //kiritSon = Convert.ToInt32(Console.ReadLine());
            //min1 = kiritSon;
            //min2 = kiritSon;
            //for (int i = 1; i < limit; i++)
            //{
            //    kiritSon = Convert.ToInt32(Console.ReadLine());
            //    if (min1 > kiritSon)
            //    {
            //        min2 = kiritSon;
            //        min1 = kiritSon;
            //    }

            //}
            //Console.WriteLine($"\n{min1} va {min2}");

            // 22 - misol 

            //int limit, kiritilganSon = 0, kiritilganniSaqla = 0, max = int.MinValue;
            //Console.Write("Limit : ");
            //limit = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= limit; i++)
            //{
            //    kiritilganSon = Convert.ToInt32(Console.ReadLine());
            //    if (max < kiritilganSon + kiritilganniSaqla)
            //    {
            //        max = kiritilganniSaqla + kiritilganSon;
            //    }
            //    kiritilganniSaqla = kiritilganSon;
            //}

            //Console.WriteLine($"max son : {max}");

            // 24 - misol


            int limit, kiritilganSon = 0, kiritilganniSaqla = 0, max = int.MinValue;
            Console.Write("Limit : ");
            limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= limit; i++)
            {
                kiritilganSon = Convert.ToInt32(Console.ReadLine());
                if (max < kiritilganSon * kiritilganniSaqla)
                {
                    max = kiritilganniSaqla * kiritilganSon;
                }
                kiritilganniSaqla = kiritilganSon;
            }

            Console.WriteLine($"max son : {max}");





        }
    }
}