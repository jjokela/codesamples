namespace Strategy
{
    public class Context
    {
        private ICustomer _customer;

        public Context()
        {
            _customer = new StandardCustomer();
        }

        public void SetCustomerStrategy(ICustomer customer) 
        {
            _customer = customer;
        }

        public double GetCustomerDiscountRate() 
        {
            return _customer.CalculateDiscount();
        }
    }
}