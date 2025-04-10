using System;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
        {;
            MilitaryUnit alpha = new MilitaryUnit(3,6,4);
            Unit beta = new SettlerUnit(4,6);
            
            alpha.Move(4);
            Console.WriteLine(alpha.Health);
            Console.WriteLine(alpha.Cost);
            alpha.Attack(beta);
            alpha.Move(6);
            Console.WriteLine(alpha.Health);
            Console.WriteLine(beta.Health);
            Console.WriteLine(alpha.Cost);
        }
    }
}
