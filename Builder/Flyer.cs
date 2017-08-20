using System.Text;

namespace Builder
{
    public class Flyer
    {
        public string Name { get; set; }
        public string Hull { get; set; }
        public string Shields { get; set; }
        public string Armor { get; set; }
        public string Guns { get; set; }
        public string Weapons { get; set; }

        public override string ToString() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name = {Name}");
            sb.AppendLine($"Hull = {Hull}");
            sb.AppendLine($"Shields = {Shields}");
            sb.AppendLine($"Armor = {Armor}");
            sb.AppendLine($"Guns = {Guns}");
            sb.AppendLine($"Weapons = {Weapons}");
            return sb.ToString();
        }
    }

}