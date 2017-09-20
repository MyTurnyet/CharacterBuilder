using Characters.Attributes;

namespace Characters.Races
{
    public class WoodElf : Elf
    {
        private readonly Speed _fleetFootBonus = new Speed(5);
        public WoodElf() : base("Wood Elf") { }
        public override ICharacterAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (CharacterAttributeScore)base.RacialAttributeAdjustment(attribute) + ApplyWisdomBonus(attribute);
        private CharacterAttributeScore ApplyWisdomBonus(ICharacterAttribute attribute) => attribute.MatchesName(CharacterAttributeName.Wisdom) ? new CharacterAttributeScore(1) : new CharacterAttributeScore(0);
        public override Speed Speed() => base.Speed() + _fleetFootBonus;
    }
}
