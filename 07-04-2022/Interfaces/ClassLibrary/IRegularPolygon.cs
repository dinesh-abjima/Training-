using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IRegularPolygon
    {
        int NumberOfSides { get; set; }
        int SideLength { get; set; }

        double GetParimeter();
        double GetArea();
    }
}
