using Characters.Attributes;

namespace Characters.Races
{
    public class MountainDwarf : Dwarf
    {
        public MountainDwarf():base("Mountain Dwarf"){}

        public override ICharacterAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (CharacterAttributeScore)base.RacialAttributeAdjustment(attribute) + ApplyStrengthBonus(attribute);
        private static CharacterAttributeScore ApplyStrengthBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Strength) ? new CharacterAttributeScore(0) : new CharacterAttributeScore(2);
    }
}