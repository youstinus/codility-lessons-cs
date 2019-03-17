using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_strontium_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(Challenge.ToInt(s[i]));
            }

            var asdad = new Challenge();
            asdad.Solution1(new string[]{"xxbxx", "xbx", "x"});
            Console.ReadKey();
        }
    }
}
