namespace Coords
{
    public struct Coordinates
    {
        public int x, y;

        public Coordinates(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public void PrintCoordinates() 
        {
            System.Console.WriteLine($"X: {x}, Y: {y}");
        }
    }
}