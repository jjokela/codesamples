using System;
using AbstractFactory.Auto;

namespace AbstractFactory.Factory
{
    public class ToyotaFactory : IAutoFactory
    {        
        public ILuxuryAuto CreateLuxuryAuto()
        {
            return new ToyotaLux();
        }
        public IBasicAuto CreateBasicAuto()
        {
            return new ToyotaBasic();
        }
    }
}