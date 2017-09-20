using Characters.Attributes;

namespace Characters.Races
{
    public class MountainDwarf : Dwarf
    {
        public MountainDwarf():base("Mountain Dwarf"){}

        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (AttributeScore)base.RacialAttributeAdjustment(attribute) + ApplyStrengthBonus(attribute);
        private static AttributeScore ApplyStrengthBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Strength) ? new AttributeScore(0) : new AttributeScore(2);
    }
}