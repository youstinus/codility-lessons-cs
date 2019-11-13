using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityASML
{
    class Solution
    {
        public int[] Fuels;
        public int solution(int[] T, bool[] B)
        {
            var t = T.ToList();
            var b = B.ToList();
            var n = T.Length;
            Fuels = new int[n];
            for (int i = 0; i < Fuels.Length; i++)
            {
                Fuels[i] = -1;
            }
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var startIndex = t.FirstOrDefault(x => x == t.IndexOf(x));
            //Was[startIndex] = true;

            var was = Sol(t, b, startIndex, 0);
            return was.Count(x => x);
        }

        public bool[] Sol(List<int> t, List<bool> b, int i, int fuel)
        {
            var indexes = getIndexes(t, i);
            var was = new bool[t.Count];
            was[i] = true;

            if (b[i] || (!b[i] && fuel > 0))
            {
                fuel = b[i] ? 2 : fuel - 1;
                Fuels[i] = fuel;
                foreach (var index in indexes)
                {
                    if (was[index] | Fuels[index] >= fuel) continue;

                    var wasIn = Sol(t, b, index, fuel);
                    was = Merge(was, wasIn);
                }
            }

            return was;
        }

        public bool[] Merge(bool[] was, bool[] wasIn)
        {
            for (var i = 0; i < was.Length; i++)
            {
                was[i] = was[i] | wasIn[i];
            }

            return was;
        }

        public List<int> getIndexes(List<int> t, int start)
        {
            var indexes = new List<int>();
            for (int i = 0; i < t.Count; i++)
            {
                if (t[i] == start)
                {
                    indexes.Add(i);
                }
            }
            indexes.Add(t[start]);

            return indexes;
        }
    }
}
