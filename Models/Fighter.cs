using System;
using System.Security.AccessControl;
using System.Collections.Generic;
using System.Globalization;
using Battle.Models.Interfaces;

namespace Battle.Models
{
    public class Fighter : ICombatant
    {
        public string Name { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }
        public int Health { get; set; }

        public Fighter()
        {
            Name = "Fighter";
            Armor = new Armor();
            Weapon = new Weapon();    
            Health = 200;
        }

        public void Attack(ICombatant enemy)
        {
            if (this.Weapon.Power > enemy.Armor.Defense) 
            {
                Console.WriteLine($"{this.Name} attacks {enemy.Name} with his {this.Weapon.Name}");
            }
            else
            {
                Console.WriteLine($"{enemy.Name} blocks {this.Name} with his {enemy.Armor.Name}");
            }
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
