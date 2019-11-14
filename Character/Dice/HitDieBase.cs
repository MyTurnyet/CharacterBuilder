using Character.Physical;

namespace Character.Dice
{
    public class HitDieBase : DieBase
    {
        protected HitDieBase(int numberOfSides) : base(numberOfSides) { }
        public IHitPoints MaxHitPoints() => new HitPoints(NumberOfSides);
    }
}
