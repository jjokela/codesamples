namespace Strategy
{
    public class Prospect : ICustomer
    {
        public double CalculateDiscount() 
        {
            return 0.0;
        }
    }
}