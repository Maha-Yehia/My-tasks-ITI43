using System.Diagnostics;

namespace task1_Day2
{
    internal class Program
    {
        static void Main(string[] args) 
        {

            //Console.WriteLine("Pleas enter the size of array");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];

            ///// add values into arr 
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            ///// print values of arr
            ////for (int i = 0; i < arr.Length; i++)
            ////{
            ////    Console.WriteLine(arr[i]);
            ////}

            //int dist = 0;
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {

            //        if (arr[i] == arr[j])
            //        {

            //            if ((j - i) > dist)
            //            {
            //                dist = (j - i);
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(" ");
            //Console.WriteLine("the max distance = " + (dist - 1));

            ///--------------------Task 2 --------------------
            //Console.WriteLine(" ");
            //Console.WriteLine("Task2");
            //Console.WriteLine(" ");

            ///without loop
            //string str = Console.ReadLine();
            //string strList = string.Join(" ", str.Split(" ").Reverse());
            //Console.WriteLine(strList);

            /// with loop
            //string str = Console.ReadLine();

            //string[] strList = str.Split(' ');

            //for (int i = 0; i < strList.Length; i++)
            //{
            //    Console.Write(strList[i]);
            //}

            //Array.Reverse(strList);

            //Console.Write(strList[0++]);

            //Console.WriteLine(strList);

            //for (int i = strlist.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(strlist[i] + " ");
            //}



            ///--------------------Task 3 --------------------
            //Console.WriteLine(" ");
            //Console.WriteLine("Task3");
            //Console.WriteLine(" ");

            ///   ///-----------------------------/10--------------
            //Stopwatch stopwatch = new();

            //stopwatch.Start(); ////16.7 secs
            //int count = 0;
            //for (int i = 1; i < Math.Pow(10, 8); i++)
            //{
            //    int j = i;
            //    while (j != 0)
            //    {
            //        if ((j % 10) == 1)
            //            count++;
            //        j /= 10;
            //    }
            //}
            //stopwatch.Stop();
            //Console.WriteLine(count);
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);

            ///   ///-----------------------------string--------------
            //Stopwatch stopwatch = new();
            //stopwatch.Start(); ////17 secs
            //int count = 0;
            //string str; 
            //    for (int i = 1; i < Math.Pow(10, 8); i++)
            //    {
            //        str = i.ToString();
            //        for (int j = 0; j < str.Length; j++)
            //        {
            //            if (str[j] == '1')
            //            {
            //                count++;
            //            }
            //        }
            //    }
            //    stopwatch.Stop();
            //    Console.WriteLine(count);
            //Console.WriteLine(stopwatch.ElapsedMilliseconds) ;


            ///   ///-----------------------------formula--------------
            ///   

            Stopwatch stopwatch = new();///37 ms
            stopwatch.Start();
            int num = 8;
            Console.WriteLine(num * Math.Pow(10, num - 1));

            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);


        }

    }
    }


