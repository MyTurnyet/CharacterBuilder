using Characters.Attributes;
using Characters.Physical;

namespace Characters.Races
{
    public class Human : CharacterRace
    {
        public Human() : base("Human") { }
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => new AttributeScore(1);
        public override ISpeed Speed() => new Speed(30);
        public override HitPoints BonusHitPoints() => new HitPoints(0);
        public override Size Size() => Physical.Size.Medium;
    }
}
