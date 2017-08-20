using System.Collections.Generic;
using System.Linq;

namespace Command
{
    // receiver knows what to do with the operations, handle the requests
    // in this case it is the adding and removing of the items
    public class Receiver // shopping cart
    {
        private List<Product> _products = new List<Product>();
        //private double _total = 0.0;

        public void AddItem(Product product)
        {            
            _products.Add(product);
        }

        public void RemoveItem(Product product)
        {
            // check if exists
            _products.Remove(product);
        }

        private double GetTotal()
        {
            return _products.Sum(p => p.Price);
        }

        public void PrintCart()
        {
            foreach (var product in _products)
            {
                System.Console.WriteLine($"{product.Name}, {product.Price} €");
            }
            System.Console.WriteLine($"Total: {GetTotal()}");
        }
    }
}