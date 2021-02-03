using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryGame
{
    class Gopnik : IEnemy
    {
        public void BattleRoar()
        {
            Console.WriteLine("Do you have a phone?");
        }

        public override string ToString()
        {
            return "Gopnik";
        }
    }
}
