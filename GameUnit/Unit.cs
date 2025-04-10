using Humanizer;
using System;

namespace GameUnit
{
    public class Unit
    {
        private readonly int movement;
        public int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move(int movement)
        {
            Console.WriteLine($"This Unit moved {movement.ToRoman()} houses");
        }
    }
}
