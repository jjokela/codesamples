namespace Command
{
    public class RemoveFromCartCommand : CartCommand
    {
        public RemoveFromCartCommand(Receiver receiver, Product product) :
          base(receiver, product)
        {
        }

        public override void Execute()
        {
            _receiver.RemoveItem(_product);
        }
    }
}