using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryGame
{
    class Game : IGame
    {
        private IEnemiesFactory _factory;

        private IGameWorld _world;

        private IPlayer _player;

        public IGame AddEnemyFactory(IEnemiesFactory factory)
        {
            _factory = factory;
            return this;
        }

        public IGame AddPlayer(IPlayer player)
        {
            _player = player;
            return this;
        }

        public void Play()
        {
            if (_player == null)
            {
                throw new NullReferenceException(nameof(_player));
            }

            if (_factory == null)
            {
                throw new NullReferenceException(nameof(_factory));
            }

            var gameWorld = new GameWorldBuilder().Build(_factory);
            PrintGameWorldInfo(gameWorld);
        }

        private void PrintGameWorldInfo(IGameWorld world)
        {
            var enemies = world.Enemies;

            PrintByType("Alkash", enemies);
            PrintByType("Eksibicionist", enemies);
            PrintByType("Gopnik", enemies);
        }

        private void PrintByType(string name, IEnumerable<IEnemy> enemies)
        {
            var enemy = enemies.Count(item => item.ToString() == name);
            Console.WriteLine($"{enemy} {name}");
        }
    }
}
