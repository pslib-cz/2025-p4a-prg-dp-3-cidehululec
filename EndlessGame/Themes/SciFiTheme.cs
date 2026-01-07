using System;
using EndlessHeroJourney.Interfaces;

namespace EndlessHeroJourney.Themes
{
    public class SpaceStationLocation : ILocation
    {
        public string GetDescription() => "Opuštìná orbitální stanice Delta-9.";
        public void Enter() => Console.WriteLine($"   -> Pøistáváš v doku: {GetDescription()}");
    }

    public class AlienInvader : IEnemy
    {
        public string GetName() => "Xenomorfní parazit";
        public void Appear() => Console.WriteLine($"   -> Z ventilace se spustil {GetName()} a syèí!");
    }

    public class SciFiSpaceFactory : IWorldFactory
    {
        public ILocation CreateLocation() => new SpaceStationLocation();
        public IEnemy CreateEnemy() => new AlienInvader();
    }
}