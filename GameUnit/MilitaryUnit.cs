namespace GameUnit
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }
        public override int Health { get => base.Health+XP; }


        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }

        public override float Cost
        {
            get 
            {
                return AttackPower+XP;
            }
        }

        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower;
        }

        public override string ToString()
        {
            return $"SettlerUnit: HP={Health} Cost={Cost:f2} AP={AttackPower} XP={XP}";
        }
    }
}
