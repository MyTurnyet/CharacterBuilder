using Characters.Attributes;
using Characters.Display;
using Characters.Physical;

namespace Characters.Races
{
    public class HillDwarf:Dwarf
    {
        public HillDwarf() : base(new TextOf("Hill Dwarf")){}
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (AttributeScore)base.RacialAttributeAdjustment(attribute).Add(ApplyWisdomBonus(attribute));
        public override IHitPoints BonusHitPoints() => new HitPoints(1);
        private IAttributeScore ApplyWisdomBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Wisdom) ? new AttributeScore(0) : new AttributeScore(1);
    }
}
