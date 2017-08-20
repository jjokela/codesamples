namespace ExplicitCast
{
    public class Fahrenheit
    {
        public Fahrenheit(float temp)
        {
            degrees = temp;
        }
        
        public static explicit operator Celsius(Fahrenheit f) 
        {
            return new Celsius((5.0f / 9.0f) * (f.degrees - 32));
        }
        
        public float Degrees
        {
            get { return degrees; }
        }
        private float degrees;
    }
}