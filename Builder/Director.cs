using System.Text;

namespace Builder
{
    public class Director
    {
        private IBuilder _builder;
        public Director(IBuilder builder)
        {
            _builder = builder;
        }
        public Flyer Construct()
        {
            _builder.BuildHull();
            _builder.BuildHull();
            _builder.BuildShields();
            _builder.BuildArmor();
            _builder.BuildGuns();
            _builder.BuildWeapons();
            return _builder.GetResult();
        }
    }
}