using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ConcreteRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public ConcreteRegularPolygon(int side, int length)
        {
            NumberOfSides = side;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
