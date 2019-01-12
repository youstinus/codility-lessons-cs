
/*A non-empty array A consisting of N integers is given. Array A represents numbers on a tape.
Any integer P, such that 0 < P < N, splits this tape into two non-empty parts: A[0], A[1], ..., A[P − 1] and A[P], A[P + 1], ..., A[N − 1].
The difference between the two parts is the value of: |(A[0] + A[1] + ... + A[P − 1]) − (A[P] + A[P + 1] + ... + A[N − 1])|
In other words, it is the absolute difference between the sum of the first part and the sum of the second part.
For example, consider array A such that:
  A[0] = 3
  A[1] = 1
  A[2] = 2
  A[3] = 4
  A[4] = 3
We can split this tape in four places:
P = 1, difference = |3 − 10| = 7 
P = 2, difference = |4 − 9| = 5 
P = 3, difference = |6 − 7| = 1 
P = 4, difference = |10 − 3| = 7 
Write a function:
class Solution { public int solution(int[] A); }
that, given a non-empty array A of N integers, returns the minimal difference that can be achieved.
For example, given:
  A[0] = 3
  A[1] = 1
  A[2] = 2
  A[3] = 4
  A[4] = 3
the function should return 1, as explained above.
Write an efficient algorithm for the following assumptions:
N is an integer within the range [2..100,000];
each element of array A is an integer within the range [−1,000..1,000].*/

using System;
using System.Linq;

namespace lesson3
{
    internal class TapeEquilibrium
    {
        // 100%
        public int Solution(int[] A)
        {
            var min = int.MaxValue;
            var left = 0;
            var right = A.Sum();
            for (var i = 0; i < A.Length - 1; i++)
            {
                left += A[i];
                right -= A[i];
                var temp = Math.Abs(right - left);
                if (min > temp)
                {
                    min = temp;
                }
            }

            return min;
        }

        // 53%
        public int Solution2(int[] A)
        {
            var min = int.MaxValue;
            for (var i = 1; i < A.Length; i++)
            {
                var r = Math.Abs(A.Take(i).Sum() - A.Skip(i).Sum());
                if (min > r)
                {
                    min = r;
                }
            }
            return min;
        }

        // 60%
        public int Solution1(int[] A)
        {
            var dif = A.Skip(1).Sum() - A[0];
            var min = dif;
            for (var i = 1; i < A.Length - 1; i++)
            {
                dif -= A[i] * 2;
                if (min > Math.Abs(dif))
                {
                    min = Math.Abs(dif);
                }
            }
            return min;
        }
    }
}
