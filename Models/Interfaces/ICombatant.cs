using System.Security.Cryptography;

namespace Battle.Models.Interfaces
{
    public interface ICombatant
    {
        public string Name { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }
        public int Health {get; set; }
        void Attack(ICombatant enemy);
        void Defend(ICombatant enemy);

        void ReceiveDamage(int point, int multiplier = 1);
    }
}
