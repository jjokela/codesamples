using System;

namespace StaticCtorException
{    
    public class ClassWithStaticCtor
    {
        public static readonly string Name = "test";
        static ClassWithStaticCtor()
        {
            throw new Exception("Ctor exception");
        }
    }
}