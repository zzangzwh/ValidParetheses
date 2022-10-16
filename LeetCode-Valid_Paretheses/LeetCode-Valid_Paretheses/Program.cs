using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Valid_Paretheses
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( ValidOne("{}{)"));
            Console.ReadKey();
        }
        private static bool ValidOne(string s)
        {
            int n = 0;
            while(s.Length != n)
            {
                n = s.Length;
                s = s.Replace("()", "");
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");
            }
            if (s.Length == 0) return true;
            else
               return false;
        }
    }
}
