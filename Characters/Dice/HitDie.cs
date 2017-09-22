using Characters.Physical;
namespace Characters.Dice
{
    public class HitDie:Die
    {
        // ReSharper disable InconsistentNaming
        public new static readonly HitDie d6 = new HitDie(6);
        public new static readonly HitDie d10 = new HitDie(10);
        // ReSharper restore InconsistentNaming

        private HitDie(int numberOfSides) : base(numberOfSides)
        {
        }

        public HitPoints MaxHitPoints()
        {
            return new HitPoints(_numberOfSides);
        }
    }
}
