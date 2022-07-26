using ClassLibrary;
using System;
namespace Application
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var square = new Square(5);
            DisplayPolgon("", square);

        }

        private static void DisplayPolgon(string polygonType, dynamic Polygon)
        {
            throw new NotImplementedException();
        }
    }
}