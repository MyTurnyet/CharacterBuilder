using System.Collections.Generic;
using Character.Attributes;
using Character.Display;
using Character.Physical;
using Character.Physical.Proficiencies;
using Character.Physical.Sizes;

namespace Character.Races
{
    public abstract class Elf : CharacterRace, ICharacterRace
    {
        internal Elf(ITextObj race) : base(race){}
        public virtual IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => ApplyDexterityBonus(attribute);
        private AttributeScore ApplyDexterityBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Dexterity) ? new AttributeScore(0) : new AttributeScore(2);
        public virtual ISpeed Speed() => new Speed(30);
        public virtual ISize Size() => new Medium();
        public virtual List<IProficiency> Proficiencies()
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
