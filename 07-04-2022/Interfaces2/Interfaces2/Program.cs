using Interfaces2;
using System;
namespace Interfaces2
{
    interface IsSimple
    {
        void SimpleMethod();
    }
   
     

    public class Implimention : IsSimple
    {
        public void SimpleMethod()
        {
            Console.WriteLine("Simple function is called");
        }
    }
    class Program
    {
        public static void Main(String[] args)
        {
            IsSimple obj = new Implimention();

            obj.SimpleMethod();

           Data data = new Data2(2,6);

            double distance = data.distance;

            Console.WriteLine(distance);
        }
    }
}