using Character.Attributes;
using Character.Display;
using Character.Physical;

namespace Character.Races
{
    public class HighElf : Elf
    {
        public HighElf() : base(new TextObj("High Elf")) { }
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (AttributeScore)base.RacialAttributeAdjustment(attribute).Add(ApplyIntellegenceBonus(attribute));
        public override IHitPoints BonusHitPoints() => new HitPoints(0);
        private IAttributeScore ApplyIntellegenceBonus(ICharacterAttribute attribute) => attribute.MatchesName(CharacterAttributeName.Intelligence) ? new AttributeScore(1) : new AttributeScore(0);
    }
}
