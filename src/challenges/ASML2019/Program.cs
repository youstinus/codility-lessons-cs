using System;

namespace CodilityASML
{
    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solution();

            Console.WriteLine(sol.solution(new[] { 9, 1, 4, 9, 0, 4, 8, 1, 0, 7 }, new[] { false, true, false, true, false, false, false, false, false, false }));
            Console.WriteLine(sol.solution(new[] { 9, 1, 4, 9, 0, 4, 8, 1, 0, 7 }, new[] { true, true, false, false, false, false, false, false, false, false }));
            Console.WriteLine(sol.solution(new[] { 9, 1, 4, 9, 0, 4, 8, 1, 0, 7 }, new[] { false, true, false, false, false, false, false, false, false, true }));
            Console.WriteLine(sol.solution(new[] { 9, 1, 4, 9, 0, 4, 8, 1, 0, 7 }, new[] { false, true, false, true, false, false, false, false, false, true }));
            Console.WriteLine(sol.solution(new[] { 9, 1, 4, 9, 0, 4, 8, 1, 0, 7 }, new[] { false, true, false, false, false, false, false, true, false, false }));
            Console.WriteLine(sol.solution(new[] { 9, 1, 4, 9, 0, 4, 8, 1, 0, 7 }, new[] { false, true, false, false, false, false, false, true, false, true }));
            Console.WriteLine(sol.solution(new[] { 9, 1, 4, 9, 0, 4, 8, 1, 0, 7 }, new[] { false, true, false, false, false, false, false, false, false, true }));
            Console.WriteLine(sol.solution(new [] {0, 0, 1, 2, 3}, new [] {false, false, false, false, false}));
            Console.WriteLine(sol.solution(new [] {0, 0, 1, 2, 3}, new [] {true, false, false, false, false}));
            Console.WriteLine(sol.solution(new [] {0, 0, 1, 2, 3}, new [] {false, true, false, false, false}));
            Console.WriteLine(sol.solution(new [] {0, 0, 1, 2, 3}, new [] {false, true, true, true, true }));
            /*Console.WriteLine(res);
            Console.WriteLine(res);
            Console.WriteLine(res);*/




            Console.ReadKey();
        }
    }
}
