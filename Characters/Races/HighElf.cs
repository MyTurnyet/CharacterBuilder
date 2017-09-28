using System.Collections.Generic;
using Characters.Attributes;
using Characters.Physical;

namespace Characters.Races
{
    public class HighElf : Elf
    {
        public HighElf() : base("High Elf") { }
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (AttributeScore)base.RacialAttributeAdjustment(attribute) + ApplyIntellegenceBonus(attribute);
        public override HitPoints BonusHitPoints() => new HitPoints(0);
        public override List<Proficiency> Proficiencies()
        {
            throw new System.NotImplementedException();
        }

        private AttributeScore ApplyIntellegenceBonus(ICharacterAttribute attribute) => attribute.MatchesName(CharacterAttributeName.Intelligence) ? new AttributeScore(1) : new AttributeScore(0);
    }
}
