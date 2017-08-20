namespace Overload
{
    public class OverloadTest
    {
        public static void Display(long x)
        {
            System.Console.WriteLine($"Long: {x}");
        }

        public static void Display(int x)
        {
            System.Console.WriteLine($"Int: {x}");
        }
    }
}