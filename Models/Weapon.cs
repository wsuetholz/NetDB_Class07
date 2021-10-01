
namespace Battle.Models
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public Weapon()
        {
            Name = "Weapon";
            Power = 1;
        }
    }
}
