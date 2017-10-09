
namespace Characters.Physical
{
    public class HitPoints : IHitPoints
    {
        private readonly int _hpValue;

        public HitPoints(int value)
        {
            _hpValue = value;
        }
        public override bool Equals(object obj) => obj != null && Equals((HitPoints)obj);
        private bool Equals(HitPoints other) => _hpValue == other._hpValue;
        public static HitPoints operator +(HitPoints left, HitPoints right) => new HitPoints(left._hpValue + right._hpValue);
        public static HitPoints operator -(HitPoints left, HitPoints right) => new HitPoints(left._hpValue - right._hpValue);
    }
}
