namespace EII
{
    public class Go : IGoFast, IGoSlow
    {
        void IGoFast.Go()
        {
            System.Console.WriteLine("I go fast");
        }

        void IGoSlow.Go()
        {
            System.Console.WriteLine("I go slow");
        }
    }
}