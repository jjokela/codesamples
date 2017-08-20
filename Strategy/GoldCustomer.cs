namespace Strategy
{
    public class GoldCustomer : ICustomer
    {
        public double CalculateDiscount() 
        {
            return 0.20;
        }
    }
}