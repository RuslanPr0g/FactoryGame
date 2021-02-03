using RandomHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryGame
{
    class GameWorldBuilder : IGameWorldBuilder
    {
        private readonly List<IEnemy> _enemies;

        private readonly List<GameObject> _gameObjects;

        public GameWorldBuilder()
        {
            _enemies = new List<IEnemy>();
            _gameObjects = new List<GameObject>();
        }

        public IGameWorldBuilder AddEnemy(IEnemy enemy)
        {
            _enemies.Add(enemy);
            return this;
        }

        public IGameWorldBuilder AddGameObject(GameObject obj)
        {
            _gameObjects.Add(obj);
            return this;
        }

        public IGameWorld Build(IEnemiesFactory enemiesFactory)
        {
            #region "Build level"
            int count = RngProvider.Random.Next(10, 100);

            Console.WriteLine("Build Trees");
            for (int i = 0; i < count; i++)
            {
                this.AddGameObject(new Tree());
            }

            Console.WriteLine("Build Benchs");
            count = RngProvider.Random.Next(10, 100);
            for (int i = 0; i < count; i++)
            {
                this.AddGameObject(new Bench());
            }


            Console.WriteLine("Create enemies");
            count = 100;
            for (int i = 0; i < count; i++)
            {
                this.AddEnemy(enemiesFactory.Create());
            }

            #endregion

            return new GameWorld()
            {
                Enemies = _enemies,
                Objects = _gameObjects
            };
        }
    }
}
