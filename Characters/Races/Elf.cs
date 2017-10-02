using System.Collections.Generic;
using Characters.Attributes;
using Characters.Physical;

namespace Characters.Races
{
    public abstract class Elf : CharacterRace
    {
        internal Elf(string race) : base(race){}
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => ApplyDexterityBonus(attribute);
        private AttributeScore ApplyDexterityBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Dexterity) ? new AttributeScore(0) : new AttributeScore(2);
        public override ISpeed Speed() => new Speed(30);
        public override Size Size() => Physical.Size.Medium;
        public override List<Proficiency> Proficiencies()
        {
            return new List<Proficiency>
            {
                Proficiency.Longsword,
                Proficiency.Shortbow,
                Proficiency.Shortsword,
                Proficiency.Longbow
            };
        }
    }
}
