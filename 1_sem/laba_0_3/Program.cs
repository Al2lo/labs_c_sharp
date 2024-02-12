using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_0_3
{
    internal class start
    {
        static void Main(string[] args)
        {
            Set<int> set = new Set<int>();
            Set<string> set2 = new Set<string>();
            Set<int> set3 = new Set<int> ();
            int a = 1;

            set.Add(5);
            set3.Add(4);
            set.Add(5);
            set.Add(6);
            set.get();
            set2.Add("fd9nk8dn0g jdnjgn9");
            set2.Add("gkdh3jh");

            set = set * set3;
            Console.WriteLine(a>set);
            Console.WriteLine(set > set3);
            string s = set2.GetNumber(set2);
            Console.WriteLine(s);
            set.Delete(set);
            set.vyvod();

        }
    }
}