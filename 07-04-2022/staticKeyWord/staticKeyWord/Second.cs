using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticKeyWord
{
    public static class Second
    {
        static Second()
        {

        }

        public static int a = 2;
        public static int b = 3;

        public static void add(int a , int b)
        {
            Console.WriteLine(a*b);
        }
    }
}
