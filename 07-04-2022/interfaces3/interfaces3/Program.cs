using interfaces3;
using System;
namespace Application
{
    interface Data
    {
        public int a { get; set; }
        public int b { get; set; }

        public int distance();
    }

    class DataChild : Data
    {
        public DataChild(int aa, int bb)
        {
            a = aa;
            b = bb;
        }
        public int a { get; set; }
        public int b { get; set;}

        public int distance()
        {
            return a*b;
        }

    class Program
        {
            public static void Main(String[] args)
            {
                Data child = new DataChild(2,3);
                var ans = child.distance();
                Console.WriteLine(ans);

                MultipleInheritance ans1 = new MultipleInheritance();

                ans1.Language();
                ans1.Subject();

                
            }
        }
    }
}