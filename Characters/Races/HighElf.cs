using Characters.Attributes;

namespace Characters.Races
{
    public class HighElf : Elf
    {
        public HighElf() : base("High Elf") { }
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (AttributeScore)base.RacialAttributeAdjustment(attribute) + ApplyIntellegenceBonus(attribute);
        private AttributeScore ApplyIntellegenceBonus(ICharacterAttribute attribute) => attribute.MatchesName(CharacterAttributeName.Intelligence) ? new AttributeScore(1) : new AttributeScore(0);
    }
}
