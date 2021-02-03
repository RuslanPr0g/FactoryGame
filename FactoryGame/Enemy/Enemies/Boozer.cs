using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryGame
{
    class Boozer : IEnemy
    {
        public void BattleRoar()
        {
            Console.WriteLine("Give mi soume maney for my eduction.");
        }

        public override string ToString()
        {
            return "Alskash";
        }
    }
}
