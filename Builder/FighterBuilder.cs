using System.Text;

namespace Builder
{
    public class FighterBuilder : IBuilder
    {
        private Flyer _flyer = new Flyer();

        public FighterBuilder()
        {
            _flyer.Name = "Flyboy Special Shrike 'X'";
        }

        public void BuildHull()
        {
            _flyer.Hull = "Light";
        }
        public void BuildShields()
        {
            _flyer.Shields = "Medium";
        }
        public void BuildArmor()
        {
            _flyer.Armor = "Light";
        }
        public void BuildGuns()
        {
            _flyer.Guns = "2x Light Laser, 2x Plasma, 1x Mass Driver";
        }
        public void BuildWeapons()
        {
            _flyer.Weapons = "2x LRAAM, 2x SRAAM, 1x FOF";
        }
        public Flyer GetResult()
        {
            return _flyer;
        }
    }
}