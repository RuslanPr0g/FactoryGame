using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryGame
{
    class Exebitionist : IEnemy
    {
        public void BattleRoar()
        {
            Console.WriteLine("Hello.");
        }

        public override string ToString()
        {
            return "You";
        }
    }
}
