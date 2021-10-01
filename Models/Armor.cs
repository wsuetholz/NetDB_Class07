using System.Security.Cryptography;

namespace Battle.Models
{
    public class Armor
    {
        public string Name { get; set; }
        public int Defense { get; set; }

        public Armor()
        {
            Name = "Armor";
            Defense = 1;
        }
    }
}
