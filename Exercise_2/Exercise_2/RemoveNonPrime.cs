using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class RemoveNonPrime
    {
        public static List<int> Remove(List<int> collection)
        {
            List<int> Result = new List<int>();

            bool isPrime = true;

            Parallel.ForEach(collection, element =>
             {
                 Parallel.For(2, element / 2 + 1, (int n, ParallelLoopState state) =>
                    {
                        if (element % 2 == 0)
                        {
                            isPrime = false;
                            state.Break();
                        }
                    });

                 if (isPrime)
                 {
                     Result.Add(element);
                 }
                 isPrime = true;
             });

            return Result;
        }
    }
}
