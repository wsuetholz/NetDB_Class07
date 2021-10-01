using System;
using Battle.Models.Interfaces;

namespace Battle.Models
{
    public class Enemy : ICombatant
    {
        public string Name { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }
        public int Health { get; set; }

        public Enemy()
        {
            Name = "Enemy";
            Armor = new Armor();
            Weapon = new Weapon();   
            Health = 100; 
        
        }

        public void Attack(ICombatant enemy)
        {
            Console.WriteLine($"{this.Name} attacks {enemy.Name} with his {this.Weapon.Name}");
        }

        public void Defend(ICombatant enemy)
        {

        }

        public void ReceiveDamage(int points, int multiplier = 1)
        {
            Health = Health - (points * multiplier);
        }
    }
}
