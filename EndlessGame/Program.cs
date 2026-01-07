using System;
using EndlessHeroJourney.Core;
using EndlessHeroJourney.Themes;

namespace EndlessHeroJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            GameEngine engine = new GameEngine();

            engine.RegisterWorld(new FantasyForestFactory());
            engine.RegisterWorld(new SciFiSpaceFactory());
            engine.RegisterWorld(new UnderwaterFactory());
            engine.Start();
        }
    }
}