using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryGame
{
    interface IGameWorldBuilder
    {
        IGameWorldBuilder AddEnemy(IEnemy enemy);

        IGameWorldBuilder AddGameObject(GameObject obj);

        IGameWorld Build(IEnemiesFactory enemiesFactory);
    }
}
