using System;

namespace LazyTest
{
    public class LazyInit
    {
        private Lazy<LargeObject> largeObject = null;

        public LazyInit()
        {
            largeObject = new Lazy<LargeObject>(false);
            System.Console.WriteLine("Hoi hoi. LargeObject shouldn't be initted yet");
        }

        public void Init() 
        {
            System.Console.WriteLine("Should init the largeObject now");
            var initted = largeObject.Value;
        }

    }

    public class LargeObject 
    {
        public LargeObject()
        {
            System.Console.WriteLine("LargeObject was created");
        }
    }
}