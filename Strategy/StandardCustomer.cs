namespace Strategy
{
    public class StandardCustomer : ICustomer
    {
        public double CalculateDiscount() 
        {
            return 0.05;
        }
    }
}