using Character.Attributes;
using Character.Display;

namespace Character.Races
{
    public class HalflingLightfoot: Halfling
    {
        public HalflingLightfoot() : base(new TextObj("Halfling Lightfoot")){}
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => base.RacialAttributeAdjustment(attribute).Add(GetCharismaBonus(attribute));
        private IAttributeScore GetCharismaBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Charisma) ? new AttributeScore(0) : new AttributeScore(1);
    }
}
