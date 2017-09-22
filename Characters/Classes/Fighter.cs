using Characters.Dice;
using Characters.Physical;

namespace Characters.Classes
{
    public class Fighter:CharacterClass
    {
        public Fighter() : base("Fighter"){}
        public override HitDie HitDie() => Dice.HitDie.d10;
        public HitPoints BaseHitPoints() => HitDie().MaxHitPoints();

    }
}
