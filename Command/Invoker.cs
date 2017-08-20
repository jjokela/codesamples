using System.Collections.Generic;

namespace Command
{
    // invoker asks the command to do stuff, in this case add or remove items in shopping cart

    // note: command initialization could be set in factory

    public class Invoker // user
    {
        // for undo etc.
        private List<CartCommand> _commands = new List<CartCommand>();

        private Receiver _shoppingCart = new Receiver();

        public void AddToCart(Product product) 
        {
            var command = new AddToCartCommand(_shoppingCart, product);
            _commands.Add(command);
            command.Execute();
        }

        public void RemoveFromCart(Product product) 
        {
            var command = new RemoveFromCartCommand(_shoppingCart, product);
            _commands.Add(command);
            command.Execute();
        }

        public void GetShoppingCartContents()
        {
            _shoppingCart.PrintCart();
        }
    }
}