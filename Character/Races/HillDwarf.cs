using Character.Attributes;
using Character.Display;
using Character.Physical;

namespace Character.Races
{
    public class HillDwarf:Dwarf
    {
        public HillDwarf() : base(new TextObj("Hill Dwarf")){}
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (AttributeScore)base.RacialAttributeAdjustment(attribute).Add(ApplyWisdomBonus(attribute));
        public override IHitPoints BonusHitPoints() => new HitPoints(1);
        private IAttributeScore ApplyWisdomBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Wisdom) ? new AttributeScore(0) : new AttributeScore(1);
    }
}
