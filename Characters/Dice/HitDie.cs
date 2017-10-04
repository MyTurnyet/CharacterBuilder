using Characters.Physical;
namespace Characters.Dice
{
    public class HitDie : Die, IHitDie
    {
        public static readonly WizardHitDie Wizard = new WizardHitDie();
        public static readonly FigtherHitDie Fighter = new FigtherHitDie();

        protected HitDie(int numberOfSides) : base(numberOfSides) { }
        public HitPoints MaxHitPoints() => new HitPoints(_numberOfSides);
    }
}
