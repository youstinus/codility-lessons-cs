using System;

namespace Rubidium2018
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var test1 = new Demo();
            test1.Solution(new int[] {1, 3, 6, 4, 1, 2});

            var test2 = new Challenge();
            test2.Solution1(new int[] {0, 2}, new int[] {0, 0});
            Console.ReadKey();
        }
    }
}
