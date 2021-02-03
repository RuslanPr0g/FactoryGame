using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryGame
{
    class GameWorld : IGameWorld
    {
        public IEnumerable<GameObject> Objects { get; set; }

        public IEnumerable<IEnemy> Enemies { get; set; }
    }
}
