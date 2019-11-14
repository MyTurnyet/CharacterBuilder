using System.Collections.Generic;
using Character.Attributes;
using Character.Display;
using Character.Physical;
using Character.Physical.Proficiencies;
using Character.Physical.Sizes;

namespace Character.Races
{
    public abstract class Dwarf:CharacterRace, ICharacterRace
    {
        protected Dwarf(ITextObj race) : base(race){}
        public virtual IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => ApplyConstitutionBonus(attribute);
        private IAttributeScore ApplyConstitutionBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Constitution) ? new AttributeScore(0) : new AttributeScore(2);
        public virtual ISpeed Speed() => new Speed(25);
        public virtual ISize Size() => new Medium();
        public virtual List<IProficiency> Proficiencies()
        {
            return new List<IProficiency>
            {
                new Battleaxe(),
                new Handaxe(),
                new ThrowingHammer(),
                new Warhammer(),
                new BrewersSupplies(),
                new MasonsTools(),
                new SmithsTools()
            };
        }
    }
}
