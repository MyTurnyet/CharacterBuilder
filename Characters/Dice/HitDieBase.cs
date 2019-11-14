using Characters.Physical;

namespace Characters.Dice
{
    public class HitDieBase : DieBase
    {
        protected HitDieBase(int numberOfSides) : base(numberOfSides) { }
        public IHitPoints MaxHitPoints() => new HitPoints(NumberOfSides);
    }
}
