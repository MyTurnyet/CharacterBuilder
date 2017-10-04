using Characters.Attributes;
using Characters.Physical;

namespace Characters.Races
{
    public class HillDwarf:Dwarf
    {
        public HillDwarf() : base("Hill Dwarf"){}
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (AttributeScore)base.RacialAttributeAdjustment(attribute) + ApplyWisdomBonus(attribute);
        public override HitPoints BonusHitPoints() => new HitPoints(1);
        private AttributeScore ApplyWisdomBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Wisdom) ? new AttributeScore(0) : new AttributeScore(1);
    }
}
