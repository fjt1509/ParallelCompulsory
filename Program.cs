using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelCompulsory
{
    static class Program
    {
 
        static Object sync = new Object();
        static List<long> populatedList;

        [STAThread]
        static void Main()
        {

            Console.WriteLine("Enter FROM:");
            long from = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter TO:");
            long to = Convert.ToInt64(Console.ReadLine());

            populatedList = PopulateList(from, to);

            Stopwatch sqsw = new Stopwatch();
            sqsw.Start();
            var sequentialList = GetPrimesSequential(from, to);
            sqsw.Stop();
            Console.WriteLine($"Time for Seqential: {sqsw.ElapsedMilliseconds}");
            Console.WriteLine($"List Size for Sequential: {sequentialList.Count}");

            Stopwatch pasw = new Stopwatch();
            pasw.Start();
            var parallelList = GetPrimesParallel(from, to);
            pasw.Stop();
            Console.WriteLine($"Time for Parallel: {pasw.ElapsedMilliseconds}");
            Console.WriteLine($"List Size for Parallel: {parallelList.Count}");
     


            Stopwatch ppasw = new Stopwatch();
            ppasw.Start();
            var parallelListPLINQ = GetPrimesParallelPLINQ(from, to);
            ppasw.Stop();
            Console.WriteLine($"Time for ParallelPLINQ: {ppasw.ElapsedMilliseconds}");
            Console.WriteLine($"List Size for ParallelPLINQ: {parallelListPLINQ.Count}");
            parallelListPLINQ.ForEach(num => Console.WriteLine(num));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



        }



        static List<long> GetPrimesSequential(long from, long to)
        {
            List<long> numbers = new List<long>();

            for(long i = from; i <= to; i++)
            {
                if(i % 2 == 1)
                {
                    numbers.Add(i);
                }
            }
          return numbers;  
        }

        static List<long> GetPrimesParallel(long from, long to)
        {

            List<long> numbers = new List<long>();

            Parallel.For(from, to, i =>
            {
                if(i % 2 == 1)
                {
                    lock(sync)
                    {
                        numbers.Add(i);
                    }
                }
            });

            return numbers;       
        }


        static List<long> GetPrimesParallelPLINQ(long from, long to)
        {
           var newList = populatedList.AsParallel().Where(num => num % 2 == 1).ToList();
           return newList;
        }


        private static List<long> PopulateList(long from, long to)
        {
            List<long> list = new List<long>();

            for(long i = from; i <= to; i++)
            {
                list.Add(i);
            }
            return list;
        }




    }
}
