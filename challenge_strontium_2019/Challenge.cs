/*An array of N words is given. Each word consists of small letters ('a' − 'z').
 Our goal is to concatenate the words in such a way as to obtain a single word
 with the longest possible substring composed of one particular letter.
 Find the length of such a substring.
Write a function:
class Solution { public int solution(string[] words); }
that, given an array words containing N strings,
returns the length of the longest substring of a word created as described above.
Examples:
1. Given N=3 and words=["aabb", "aaaa", "bbab"], your function should return 6.
One of the best concatenations is words[1] + words[0] + words[2] = "aaaaaabbbbab".
The longest substring is composed of letter 'a' and its length is 6.
2. Given N=3 and words=["xxbxx", "xbx", "x"], your function should return 4.
One of the best concatenations is words[0] + words[2] + words[1] = "xxbxxxxbx".
The longest substring is composed of letter 'x' and its length is 4.
3. Given N=4 and words=["dd", "bb", "cc", "dd"], your function should return 4.
One of the best concatenations is words[0] + words[3] + words[1] + words[2] = "ddddbbcc".
The longest substring is composed of letter 'd' and its length is 4.
Write an efficient algorithm for the following assumptions:
N is an integer within the range [1..100,000];
all the words are non−empty and consist only of lowercase letters (a−z);
S denotes the sum of the lengths of words; S is an integer within the range [1..100,000].*/

using System;
using System.Linq;

namespace challenge_strontium_2019
{
    class Challenge
    {
        // Task Score- 48%, Correctness- 50%, Performance- 45%
        public int Solution1(string[] words)
        {
            var histo = new int[26];
            var histoLeft = new int[26];
            var histoRight = new int[26];
            var hl = new int[26];
            var hr = new int[26];
            var hl2 = new int[26];
            var hr2 = new int[26];
            var histoMiddle = new int[26];

            for (var i = 0; i < words.Length; i++)
            {
                var same1 = Same(words[i]);
                var sameB = false;
                if (same1 == words[i].Length)
                {
                    sameB = true;
                    var whitch = ToInt(words[i].First());
                    histo[whitch] += same1;
                    
                }

                var tokiePat = false;
                if (!sameB && words[i].First() == words[i].Last())
                {
                    int la;
                    int ra;
                    LR(words[i], out la, out ra);
                    var whitcho = ToInt(words[i].First());
                    if (la - hl[whitcho] < ra - hr2[whitcho])
                    {
                        hl2[whitcho] = la;
                        hr2[whitcho] = ra;
                    }
                    else
                    {
                        hl[whitcho] = la;
                        hr[whitcho] = ra;
                    }


                    tokiePat = true;
                }

                if (!sameB && !tokiePat)
                {
                    var whitchl = ToInt(words[i].First());
                    var whitchR = ToInt(words[i].Last());
                    var howL = Left(words[i]);
                    var howR = Right(words[i]);

                    if (histoLeft[whitchl] < howL)
                    {
                        histoLeft[whitchl] = howL;
                    }

                    if (histoRight[whitchR] < howR)
                    {
                        histoRight[whitchR] = howR;
                    }
                    
                    char seco;
                    var mile = Middle(words[i], out seco);
                    if (mile > 0)
                    {
                        histoMiddle[ToInt(seco)] = mile;
                    }
                }
            }

            var mainHisto = new int[26];
            for (var i = 0; i < 26; i++)
            {
                var kar = 0;
                var des = 0;
                if (histoLeft[i] > hl[i])
                {
                    kar = histoLeft[i];
                }
                else
                {
                    kar = hl[i];
                }

                if (histoRight[i] > hr2[i])
                {
                    des = histoRight[i];
                }
                else
                {
                    des = hr2[i];
                }

                mainHisto[i] = histo[i] + kar + des;
                if (mainHisto[i] < histoMiddle[i])
                {
                    mainHisto[i] = histoMiddle[i];
                }
            }

            return mainHisto.Max();
        }

        public static int ToInt(char c)
        {
            // zero based index
            // return ((int)(c - '0')) - 64;
            return ((int)char.ToUpper(c)) - 65;
        }

        public int Left(string s)
        {
            var begin = 1;
            var first = s.First();
            for (var i = 1; i < s.Length; i++)
            {
                if (first.Equals(s[i]))
                {
                    begin++;
                }
                else
                {
                    return begin;
                }
            }

            return begin;
        }

        public int Right(string s)
        {
            var end = 1;
            var first = s.Last();
            for (var i = s.Length - 2; i >= 0; i--)
            {
                if (first.Equals(s[i]))
                {
                    end++;
                }
                else
                {
                    return end;
                }
            }

            return end;
        }

        public void LR(string s, out int l, out int r)
        {
            l = 0;
            r = 0;
            if (s.Length > 2)
            {
                l = Left(s);
                r = Right(s);
            }
        }

        public int Same(string s)
        {
            var first = s.First();
            for (var i = 1; i < s.Length; i++)
            {
                if (!first.Equals(s[i]))
                    return 0;
            }

            return s.Length;
        }

        public int Middle(string a, out char second)
        {
            if (a.Length > 4)
            {
                second = a[1];
                var sum = 1;
                var max = 0;
                for (var i = 2; i < a.Length; i++)
                {
                    if (second == a[i])
                    {
                        sum++;
                    }
                    else
                    {
                        if (max < sum)
                        {
                            max = sum;
                        }
                        second = a[i];
                    }
                }
                return max < sum ? sum : max;
            }
            else if (a.Length == 3)
            {
                second = a[1];
                return 1;
            }
            else if (a.Length <= 2)
            {
                second = '0';
                return 0;
            }

            second = '0';
            return 0;
        }

        public int BeginEndMax(string s)
        {
            var begin = 1;
            var proceedBegin = true;
            var end = 1;
            var proceedEnd = true;
            var first = s.First();
            var last = s.Last();
            for (var i = 1; i < s.Length - 1; i++)
            {
                if (proceedBegin && first.Equals(s[i]))
                {
                    begin++;
                }
                else
                {
                    proceedBegin = false;
                }

                if (proceedEnd && last.Equals(s[s.Length - i - 1]))
                {
                    end++;
                }
                else
                {
                    proceedEnd = false;
                }
            }

            return begin + end >= s.Length ? s.Length : Math.Max(begin, end);
        }

        public bool AllEqual(string s)
        {
            var first = s[0];
            for (var i = 1; i < s.Length; i++)
            {
                if (!first.Equals(s[i]))
                    return false;
            }

            return true;
        }

        public int What(string a)
        {
            var first = a[0];
            var sum = 1;
            var max = 0;
            for (var i = 0; i < a.Length - 1; i++)
            {
                if (first == a[i + 1])
                {
                    sum++;
                }
                else
                {
                    if (max < sum)
                    {
                        max = sum;
                    }
                    first = a[i + 1];
                }
            }
            return max < sum ? sum : max;
        }
    }
}
