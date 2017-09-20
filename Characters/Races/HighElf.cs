using Characters.Attributes;

namespace Characters.Races
{
    public class HighElf : Elf
    {
        public HighElf() : base("High Elf") { }
        public override ICharacterAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (CharacterAttributeScore)base.RacialAttributeAdjustment(attribute) + ApplyIntellegenceBonus(attribute);
        private CharacterAttributeScore ApplyIntellegenceBonus(ICharacterAttribute attribute) => attribute.MatchesName(CharacterAttributeName.Intelligence) ? new CharacterAttributeScore(1) : new CharacterAttributeScore(0);
    }
}
