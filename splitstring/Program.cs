using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace splitstring
{
    class Program
    {
        static void Main(string[] args)
        {
            fullname("Supraja Baratam");
        }
        static void fullname(string arr)
        {
            string[] s = arr.Split();
            foreach (string p in s)
            {
                Console.WriteLine(p);
            }
        }
    }
}
