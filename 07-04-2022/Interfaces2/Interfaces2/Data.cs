using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    public interface Data
    {
        int X { get; set; }
        int Y { get; set; }
        double distance { get;}

    }

    class Data2 : Data
    {
         

        public Data2(int x,int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
        
        public double distance =>
                    Math.Sqrt(X * X + Y * Y);

    }
}
