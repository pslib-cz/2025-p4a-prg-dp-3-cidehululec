namespace EndlessHeroJourney.Interfaces
{
    public interface IWorldFactory
    {
        ILocation CreateLocation();
        IEnemy CreateEnemy();
    }
}