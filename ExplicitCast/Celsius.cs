namespace ExplicitCast
{
    public class Celsius
    {
        public Celsius(float temp)
        {
            degrees = temp;
        }
        
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit((9.0f / 5.0f) * c.degrees + 32);
        }

        public float Degrees
        {
            get { return degrees; }
        }
        private float degrees;
    }
}