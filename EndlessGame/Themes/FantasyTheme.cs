using System;
using EndlessHeroJourney.Interfaces;

namespace EndlessHeroJourney.Themes
{
    public class ForestLocation : ILocation
    {
        public string GetDescription() => "Temný hvozd plný prastarých stromù.";
        public void Enter() => Console.WriteLine($"   -> Vstupuješ do: {GetDescription()}");
    }

    public class ForestGoblin : IEnemy
    {
        public string GetName() => "Skøet záškodník";
        public void Appear() => Console.WriteLine($"   -> Z køoví vyskoèil {GetName()} a mává kyjem!");
    }

    public class FantasyForestFactory : IWorldFactory
    {
        public ILocation CreateLocation() => new ForestLocation();
        public IEnemy CreateEnemy() => new ForestGoblin();
    }
}