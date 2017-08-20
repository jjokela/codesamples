using System.Text;

namespace Builder
{
    public class BomberBuilder : IBuilder
    {
        private Flyer _flyer = new Flyer();

        public BomberBuilder()
        {
            _flyer.Name = "Heavy Bomber Mk. 3 'Hellbore'";
        }

        public void BuildHull()
        {
            _flyer.Hull = "Heavy";
        }
        public void BuildShields()
        {
            _flyer.Shields = "Heavy";
        }
        public void BuildArmor()
        {
            _flyer.Armor = "Heavy";
        }
        public void BuildGuns()
        {
            _flyer.Guns = "2x Twin-Laser turrets, 1x Flak";
        }
        public void BuildWeapons()
        {
            _flyer.Weapons = "8x Torpedo, 2x Heavy Rocket, 2x FOF";
        }
        public Flyer GetResult()
        {
            return _flyer;
        }
    }
}