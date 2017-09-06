namespace PropertyInitializers
{
    public class PropertyInitializerTest
    {
        // initialize property
        public int TestInt { get; set; } = 100;

        // it is same as readonly, so can be overridden in constructor
        public int TestIntOverride { get; set; } = 200;

        // returns always the same value
        public int AlwaysSame => 999;
        // same as public int AlwaysSame { get { return 999; } }
        public PropertyInitializerTest()
        {
            TestIntOverride = 123;
            // doesn't work
            //AlwaysSame = 1;
        }

    }
}