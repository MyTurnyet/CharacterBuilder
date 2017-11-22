using System.Collections.Generic;
using Characters.Attributes;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Physical.Sizes;

namespace Characters.Races
{
    public abstract class Elf : CharacterRace, ICharacterRace
    {
        internal Elf(ITextObj race) : base(race){}
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => ApplyDexterityBonus(attribute);
        private AttributeScore ApplyDexterityBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Dexterity) ? new AttributeScore(0) : new AttributeScore(2);
        public override ISpeed Speed() => new Speed(30);
        public override ISize Size() => new Medium();
        public override List<IProficiency> Proficiencies()
        {
            return new List<IProficiency>
            {
                new Longsword(),
                new Shortbow(),
                new Shortsword(),
                new Longbow()
            };
        }
    }
}
