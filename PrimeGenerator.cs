using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelCompulsory
{
    public class PrimeGenerator
    {
        public List<long> GetPrimesParallel(long from, long to)
        {
            Object sync = new Object();
            List<List<long>> partitionedPrimes = new List<List<long>>();

            var partition = Partitioner.Create(from, to);

            Parallel.ForEach(partition, (range) =>
            {
                List<long> localPrimes = new List<long>();

                for (long i = range.Item1; i < range.Item2; i++)
                {
                    if (IsPrime(i))
                    {
                        localPrimes.Add(i);
                    }
                }

                lock (sync)
                {
                    partitionedPrimes.Add(localPrimes);
                }
            });



            partitionedPrimes.RemoveAll(list => list.Count == 0);
            List<long> sortedList = new List<long>();

            List<List<long>> sortedContainer = partitionedPrimes.OrderBy(list => list[0]).ToList();
            sortedContainer.ForEach(list => sortedList.AddRange(list));


            return sortedList;

        }

        public List<long> GetPrimesSequential(long from, long to)
        {
            List<long> numbers = new List<long>();

            for (long i = from; i <= to; i++)
            {
                if (IsPrime(i))
                {
                    numbers.Add(i);
                }
            }
            return numbers;
        }

        private Boolean IsPrime(long num)
        {
            int occourances = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    occourances++;
                }
            }

            if (occourances == 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
