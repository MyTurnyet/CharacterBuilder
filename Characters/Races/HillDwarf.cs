using Characters.Attributes;

namespace Characters.Races
{
    public class HillDwarf:Dwarf
    {
        public HillDwarf() : base("Hill Dwarf"){}
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (AttributeScore)base.RacialAttributeAdjustment(attribute) + ApplyWisdomBonus(attribute);
        private AttributeScore ApplyWisdomBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Wisdom) ? new AttributeScore(0) : new AttributeScore(1);
    }
}
