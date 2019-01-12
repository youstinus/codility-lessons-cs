using System;

namespace lesson6
{
    // 62%
    class NumberOfDiscIntersections
    {
        public int Solution(int[] A)
        {
            var index = 0;
            for (var i = 0; i < A.Length; i++)
            {
                for (int k = 0; k < A.Length; k++)
                {
                    var dist = Math.Abs(i - k);
                    long a = A[i];
                    long b = A[k];
                    if (a + b >= dist)
                    {
                        index++;
                    }
                }

                if (index - A.Length > 20000000)
                    return -1;
            }

            return (index - A.Length) / 2;
        }
    }
}
