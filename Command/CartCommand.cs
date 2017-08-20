namespace Command
{
    public abstract class CartCommand
    {
        protected Product _product;
        protected Receiver _receiver;

        // Constructor
        public CartCommand(Receiver receiver, Product product)
        {
            _receiver = receiver;
            _product = product;
        }

        public abstract void Execute();
    }
}