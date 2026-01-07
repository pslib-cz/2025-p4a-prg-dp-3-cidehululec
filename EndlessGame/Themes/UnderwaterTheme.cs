using System;
using EndlessHeroJourney.Interfaces;

namespace EndlessHeroJourney.Themes
{
    public class UnderwaterRuinsLocation : ILocation
    {
        public string GetDescription() => "Potopené ruiny atlantského chrámu.";
        public void Enter() => Console.WriteLine($"   -> Plaveš smìrem k: {GetDescription()}");
    }

    public class SeaMonster : IEnemy
    {
        public string GetName() => "Krakenovo mládì";
        public void Appear() => Console.WriteLine($"   -> Z temné hlubiny se vynoøilo {GetName()}!");
    }

    public class UnderwaterFactory : IWorldFactory
    {
        public ILocation CreateLocation() => new UnderwaterRuinsLocation();
        public IEnemy CreateEnemy() => new SeaMonster();
    }
}