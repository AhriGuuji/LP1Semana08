namespace GameUnit
{
    public class SettlerUnit : Unit
    {
        public SettlerUnit(int mov, int health) : base(mov, health)
        {
            mov = 1;
            health = 3;
        }

        public override float Cost
        {
            get
            {
                return 5f;
            }
        }
    }
}