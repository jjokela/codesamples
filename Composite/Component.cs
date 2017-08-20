namespace Composite
{
    public abstract class Component
    {
        protected double cost;
        protected string name;

        public Component(string name, double cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public abstract double GetCost();
        public abstract void Display(int depth);
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
    }
}