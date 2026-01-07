using System;
using System.Collections.Generic;
using System.Threading;
using EndlessHeroJourney.Interfaces;

namespace EndlessHeroJourney.Core
{
    public class GameEngine
    {
        private List<IWorldFactory> _registeredWorlds = new List<IWorldFactory>();
        private Random _random = new Random();

        public void RegisterWorld(IWorldFactory worldFactory)
        {
            _registeredWorlds.Add(worldFactory);
        }

        public void Start()
        {
            if (_registeredWorlds.Count == 0)
            {
                Console.WriteLine("Chyba: Žádné svìty nebyly zaregistrovány!");
                return;
            }

            Console.WriteLine("Hra zaèíná: Nekoneèná cesta hrdiny...");

            while (true)
            {
                var currentFactory = _registeredWorlds[_random.Next(_registeredWorlds.Count)];

                ILocation location = currentFactory.CreateLocation();
                IEnemy enemy = currentFactory.CreateEnemy();

                Console.WriteLine();
                Console.WriteLine("--- NOVÁ LOKACE ---");
                
                location.Enter();
                Thread.Sleep(800);

                enemy.Appear();

                Console.WriteLine("... Probíhá epický souboj ...");
                Thread.Sleep(1000);

                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}