
/*This is a demo task.
Write a function:
class Solution { public int solution(int[] A); }
that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
Given A = [1, 2, 3], the function should return 4.
Given A = [−1, −3], the function should return 1.
Write an efficient algorithm for the following assumptions:
N is an integer within the range [1..100,000];
each element of array A is an integer within the range [−1,000,000..1,000,000].*/

using System.Linq;

namespace challenge1_rubidium_2018
{
    // Rubidium 2018
    class Demo
    {
        // 100%
        public int Solution(int[] A)
        {
            var sorted = A.Where(x => x > 0).OrderBy(x => x).Distinct().ToList();
            for (var i = 0; i < sorted.Count(); i++)
            {
                if (sorted[i] != i + 1)
                    return i + 1;
            }
            return sorted.LastOrDefault() + 1;
        }
    }
}
