using System.Collections.Generic;
using Characters.Attributes;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;

namespace Characters.Races
{
    public class MountainDwarf : Dwarf
    {
        public MountainDwarf():base(new TextOf("Mountain Dwarf")){}
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (AttributeScore)base.RacialAttributeAdjustment(attribute) + ApplyStrengthBonus(attribute);
        public override IHitPoints BonusHitPoints() => new HitPoints(0);
        public override List<IProficiency> Proficiencies() => new List<IProficiency>(base.Proficiencies()) { new LightArmor(), new MediumArmor() };
        private static AttributeScore ApplyStrengthBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Strength) ? new AttributeScore(0) : new AttributeScore(2);
    }
}