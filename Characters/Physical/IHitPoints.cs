namespace Characters.Physical
{
    public interface IHitPoints
    {
        IHitPoints Add(IHitPoints hitPointsToAdd);
        bool Equals(object obj);
        IHitPoints Subtract(IHitPoints hitPointsToSubtract);
    }
}