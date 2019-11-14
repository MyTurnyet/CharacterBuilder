
namespace Character.Physical
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class HitPoints : IHitPoints

    {
        private readonly int _hpValue;

        public HitPoints(int value)
        {
            _hpValue = value;
        }
        public override bool Equals(object obj) => obj != null && Equals((HitPoints)obj);
        public IHitPoints Subtract(IHitPoints hitPointsToSubtract) => new HitPoints(_hpValue - ((HitPoints)hitPointsToSubtract)._hpValue);
        private bool Equals(HitPoints other) => _hpValue == other._hpValue;
        public IHitPoints Add(IHitPoints hitPointsToAdd) => new HitPoints(_hpValue + ((HitPoints)hitPointsToAdd)._hpValue);
    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
