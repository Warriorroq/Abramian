using System;
using System.Linq;
using System.Collections.Generic;
namespace Abramyan
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(For11(5));
            Console.WriteLine(Series8(new int[] { 2, 4, 56, 73, 2, 4, 1 }));
            Console.WriteLine(Array3(4,1,2));
            Console.WriteLine(Array11(3, new int[] { 2, 4, 56, 73, 2, 4, 1 , 3, 5, 6, 7, 9, 10}));
        }
        private static int For11(int N)
            => Enumerable.Range(N, 2 * N).Select(x => x * x).Sum();
        private static string Series8(params int[] N)
            => string.Join(' ', TakeEvenNums(N));
        private static IEnumerable<int> TakeEvenNums(params int[] N)
            => N.Where(x => x % 2 == 0);
        private static string Array3(int countOfNUms, int firstNum, int delta)
            => string.Join(' ', ArihmeticProgress(countOfNUms, firstNum, delta));
        private static IEnumerable<int> ArihmeticProgress(int countOfNums, int firstNum, int delta)
            => Enumerable.Range(0, countOfNums).Select(x => firstNum + delta * x);
        private static string Array11(int K, params int[] arr)
            => string.Join(' ',TakeKThings(K, arr));
        private static IEnumerable<int> TakeKThings(int K, params int[] arr)
            => Enumerable.Range(0, arr.Length / K).Select(x => arr[x * K]);
    }
}
