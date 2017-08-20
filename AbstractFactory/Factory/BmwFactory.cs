using System;
using AbstractFactory.Auto;

namespace AbstractFactory.Factory
{
    public class BmwFactory : IAutoFactory
    {        
        public ILuxuryAuto CreateLuxuryAuto()
        {
            return new BmwLux();
        }
        public IBasicAuto CreateBasicAuto()
        {
            return new BmwBasic();
        }
    }
}