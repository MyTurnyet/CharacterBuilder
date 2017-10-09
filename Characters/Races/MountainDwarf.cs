using System.Collections.Generic;
using Characters.Attributes;
using Characters.Physical;

namespace Characters.Races
{
    public class MountainDwarf : Dwarf
    {
        public MountainDwarf():base(new TextOf("Mountain Dwarf")){}
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (AttributeScore)base.RacialAttributeAdjustment(attribute) + ApplyStrengthBonus(attribute);
        public override HitPoints BonusHitPoints() => new HitPoints(0);
        public override List<Proficiency> Proficiencies() => new List<Proficiency>(base.Proficiencies()) { Proficiency.LightArmor, Proficiency.MediumArmor };
        private static AttributeScore ApplyStrengthBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Strength) ? new AttributeScore(0) : new AttributeScore(2);
    }
}