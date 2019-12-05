namespace Battleships
{
    public class Coord
    {
        public int XAxis { get; }
        public int YAxis { get; }

        public Coord(int xAxis, int yAxis)
        {
            XAxis = xAxis;
            YAxis = yAxis;
        }
    }
}