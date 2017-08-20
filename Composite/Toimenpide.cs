using System;

namespace Composite
{
    public class Toimenpide : Component
    {
        public Toimenpide(string name, double cost) : base(name, cost)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " " + cost);
        }

        public override double GetCost()
        {
            return cost;
        }

        public override void Add(Component c)
        {
            System.Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            System.Console.WriteLine("Cannot remove from a leaf");
        }        
    }
}