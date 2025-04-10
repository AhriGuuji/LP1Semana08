using Humanizer;
using System;

namespace GameUnit
{
    public abstract class Unit
    {
        private readonly int movement;
        public abstract float Cost { get; }
        public virtual int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move(int movement)
        {
            Console.WriteLine($"This Unit moved {movement.ToRoman()} houses");
        }

        public override string ToString()
        {
            return $"SettlerUnit: HP={Health} Cost={Cost:f2}";
        }
    }
}
