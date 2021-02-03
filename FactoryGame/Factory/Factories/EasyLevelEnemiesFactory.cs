using RandomHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryGame.Factory.Factories
{
    class EasyLevelEnemiesFactory : IEnemiesFactory
    {
        private readonly List<Type> _enemies = new List<Type>()
        {
            typeof(Boozer),
            typeof(Exebitionist),
            typeof(Gopnik)
        };

        public IEnemy Create()
        {
            var enemyIndex = RngProvider.Random.Next(0, _enemies.Count);
            var typeOfEnemy = _enemies[enemyIndex];

            return Activator.CreateInstance(typeOfEnemy) as IEnemy;
        }

        public override string ToString()
        {
            return "Easy level";
        }
    }
}
