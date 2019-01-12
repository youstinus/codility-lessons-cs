
/*A non-empty array A consisting of N integers is given.
A permutation is a sequence containing each element from 1 to N once, and only once.
For example, array A such that:
    A[0] = 4
    A[1] = 1
    A[2] = 3
    A[3] = 2
is a permutation, but array A such that:
    A[0] = 4
    A[1] = 1
    A[2] = 3
is not a permutation, because value 2 is missing.
The goal is to check whether array A is a permutation.
Write a function:
class Solution { public int solution(int[] A); }
that, given an array A, returns 1 if array A is a permutation and 0 if it is not.
For example, given array A such that:
    A[0] = 4
    A[1] = 1
    A[2] = 3
    A[3] = 2
the function should return 1.
Given array A such that:
    A[0] = 4
    A[1] = 1
    A[2] = 3
the function should return 0.
Write an efficient algorithm for the following assumptions:
N is an integer within the range [1..100,000];
each element of array A is an integer within the range [1..1,000,000,000].*/

using System.Linq;

namespace lesson4
{
    internal class PermCheck
    {
        // 100%
        public int Solution(int[] A)
        {
            var length = A.Distinct().ToList().Count;
            if (length < A.Length)
                return 0;

            var max = A.Max();
            return max == A.Length ? 1 : 0;
        }

        // 83%
        public int Solution1(int[] A)
        {
            if (A.Distinct().ToArray().Length < A.Length)
                return 0;

            return (A.Max() - A.Length + 1) % 2;
        }

        public int Solution2(int[] A)
        {
            if (A.Distinct().ToArray().Length < A.Length)
                return 0;

            return A.Max() == A.Length ? 1 : 0;
        }
    }
}
