using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryGame
{
    interface IGameWorld
    {
        IEnumerable<GameObject> Objects { get; set; }

        IEnumerable<IEnemy> Enemies { get; set; }
    }
}
