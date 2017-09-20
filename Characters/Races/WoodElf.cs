using Characters.Attributes;

namespace Characters.Races
{
    public class WoodElf : Elf
    {
        private readonly Speed _fleetFootBonus = new Speed(5);
        public WoodElf() : base("Wood Elf") { }
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (AttributeScore)base.RacialAttributeAdjustment(attribute) + ApplyWisdomBonus(attribute);
        private AttributeScore ApplyWisdomBonus(ICharacterAttribute attribute) => attribute.MatchesName(CharacterAttributeName.Wisdom) ? new AttributeScore(1) : new AttributeScore(0);
        public override Speed Speed() => base.Speed() + _fleetFootBonus;
    }
}
