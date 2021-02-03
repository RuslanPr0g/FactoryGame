using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryGame.Factory.Factories
{
    class MiddleLevelEnemiesFactory : IEnemiesFactory
    {
        private static readonly int hardEnemiesToCreate = 10;
        private static int hardEnemiesCreated = 0;

        public IEnemy Create()
        {
            if (hardEnemiesCreated < hardEnemiesToCreate)
            {
                hardEnemiesCreated++;
                return new Gopnik();
            }

            var easyLevelFactory = new EasyLevelEnemiesFactory();
            return easyLevelFactory.Create();
        }

        public override string ToString()
        {
            return "Medium rare";
        }
    }
}
