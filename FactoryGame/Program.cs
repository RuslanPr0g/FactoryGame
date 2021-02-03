using System;

namespace FactoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var levels = new List<IEnemiesFactory>()
            {
                new EasyLevelEnemiesFactory(),
                new MiddleLevelEnemiesFactory(),
                new HardLevelEnemiesFactory()
            };

            Console.WriteLine("Select level: ");

            for (int i = 0; i < levels.Count; i++) 
            {
                Console.WriteLine($"{i + 1}. {levels[i]}");
            }

            var userEnteredValue = Console.ReadLine();

            var isSuccess = Int32.TryParse(userEnteredValue, out int selectedLevel);

            if (!isSuccess)
            {
                Console.WriteLine("Critical error, all system crashed, pleaze reboooot ue pc");
                Console.ReadKey();
                return;
            }

            selectedLevel--;

            if (selectedLevel > -1 && selectedLevel < levels.Count)
            {

                IGame game = new Game();
                IEnemiesFactory factory = levels[selectedLevel];

                game.AddPlayer(new Player())
                    .AddEnemyFactory(factory);

                game.Play();
            }
            else
            {
                Console.WriteLine("Wtf are you providing me?");
            }

            Console.ReadKey();
        }

    }
}
