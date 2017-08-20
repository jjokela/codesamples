using System;
using System.Collections.Generic;

namespace Composite
{
    public class Hoitotapahtuma : Component
    {
        private List<Component> _children = new List<Component>();
        
        public Hoitotapahtuma(string name, double cost) : base(name, cost)
        {
        }

        public override void Add(Component c)
        {
            _children.Add(c);
        }

        public override void Remove(Component c)
        {
            _children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " " + cost);

            // Recursively display child nodes
            foreach (Component component in _children)
            {
                component.Display(depth + 2);
            }
        }

        public override double GetCost()
        {
            var totalCost = cost;
            foreach (Component component in _children)
            {
                totalCost += component.GetCost();
            }
            return totalCost;
        }
    }
}