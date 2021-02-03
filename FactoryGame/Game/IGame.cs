using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryGame
{
    interface IGame
    {
        IGame AddEnemyFactory(IEnemiesFactory factory);

        IGame AddPlayer(IPlayer player);

        void Play();
    }
}
