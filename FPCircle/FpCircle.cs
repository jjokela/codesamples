using static System.Math;

namespace FPCircle
{
    public class FpCircle
    {

        // public FpCircle(double radius)
        // {
        //     Radius = radius;            
        // }

        // same as commented-out ctor above
        public FpCircle(double radius)
            => Radius = radius;

        // read-only
        public double Radius { get; }

        // pure function, returns always the same result
        public double Circumference // kehä
            => PI * 2 * Radius;

        public double Area
        {
            get
            {
                // local function method, only accessible in here, also uses simplified syntax => instead of { return ...}
                double Square(double d) => Pow(d, 2);
                // calls local function method
                return PI * Square(Radius);
            }
        }

        // returns a tuple with named parameters
        public (double Circumference, double Area) Stats => (Circumference, Area);

        // longer way to write the same as above
        // public (double Circumference, double Area) Stats
        // {
        //     get { return (Circumference, Area); }
        // }

        // triple tuple
        public (double Circumference, double Area, double Radius) TripleTupleStats => (Circumference, Area, Radius);

    }
}