using System.Text;

namespace Builder
{
    public interface IBuilder
    {
        void BuildHull();
        void BuildShields();
        void BuildArmor();
        void BuildGuns();
        void BuildWeapons();
        Flyer GetResult();
    }
}