namespace Readonly
{
    public class Derived : Base
    {        
        public Derived()
        {
            // can't assign
            // readonlyString = "rai rai";
        }
    }
}