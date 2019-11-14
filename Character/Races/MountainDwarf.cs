using System.Collections.Generic;
using Character.Attributes;
using Character.Display;
using Character.Physical;
using Character.Physical.Proficiencies;

namespace Character.Races
{
    public class MountainDwarf : Dwarf
    {
        public MountainDwarf():base(new TextObj("Mountain Dwarf")){}
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (AttributeScore)base.RacialAttributeAdjustment(attribute).Add(ApplyStrengthBonus(attribute));
        public override IHitPoints BonusHitPoints() => new HitPoints(0);
        public override List<IProficiency> Proficiencies() => new List<IProficiency>(base.Proficiencies()) { new LightArmor(), new MediumArmor() };
        private static IAttributeScore ApplyStrengthBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Strength) ? new AttributeScore(0) : new AttributeScore(2);
    }
}