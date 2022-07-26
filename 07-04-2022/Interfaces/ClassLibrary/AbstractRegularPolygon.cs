namespace ClassLibrary
{
    public abstract class AbstractRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public AbstractRegularPolygon(int side, int length)
        {
            NumberOfSides = side;
            SideLength = length;
        }
        public double GetParimeter()
        {
            return SideLength * NumberOfSides;
        }

        public abstract double GetArea();

    }
}