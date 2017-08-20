namespace Command
{
    public class AddToCartCommand : CartCommand
    {
        public AddToCartCommand(Receiver receiver, Product product) :
          base(receiver, product)
        {
        }

        public override void Execute()
        {
            _receiver.AddItem(_product);
        }
    }
}