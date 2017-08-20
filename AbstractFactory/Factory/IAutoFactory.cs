using AbstractFactory.Auto;

namespace AbstractFactory.Factory
{
    public interface IAutoFactory
    {
        ILuxuryAuto CreateLuxuryAuto();
        IBasicAuto CreateBasicAuto();
    }

}