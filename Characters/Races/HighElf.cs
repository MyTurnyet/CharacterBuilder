using Characters.Attributes;
using Characters.Display;
using Characters.Physical;

namespace Characters.Races
{
    public class HighElf : Elf
    {
        public HighElf() : base(new TextOf("High Elf")) { }
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (AttributeScore)base.RacialAttributeAdjustment(attribute) + (AttributeScore)ApplyIntellegenceBonus(attribute);
        public override IHitPoints BonusHitPoints() => new HitPoints(0);
        private IAttributeScore ApplyIntellegenceBonus(ICharacterAttribute attribute) => attribute.MatchesName(CharacterAttributeName.Intelligence) ? new AttributeScore(1) : new AttributeScore(0);
    }
}
