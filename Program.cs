using System.Security.Authentication;
using System.Collections.Generic;
using System;
using Battle.Models;
using Battle.Models.Interfaces;

namespace Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Fighter
            Fighter fighter = new Fighter();
            
            // Equip Armor
            fighter.Armor.Defense = 10;

            // Equip Weapon
            fighter.Weapon.Power = 10;

            // Create Enemies
            Enemy enemy = new Enemy();
            enemy.Armor.Defense = 10;
            enemy.Weapon.Power = 10;

            // Attack Enemy
            fighter.Attack(enemy);

            Console.WriteLine($"Fighter {fighter.Name} health status is {fighter.Health}.");
            Console.WriteLine($"Fighter {fighter.Name} took 10 points of damage");
            fighter.ReceiveDamage(10);
            Console.WriteLine($"Fighter {fighter.Name} health status is {fighter.Health}.");
        }
    }
}
