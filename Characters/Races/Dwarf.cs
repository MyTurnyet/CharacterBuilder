using System.Collections.Generic;
using Characters.Attributes;
using Characters.Physical;
using Characters.Physical.Proficiencies;

namespace Characters.Races
{
    public abstract class Dwarf:CharacterRace
    {
        protected Dwarf(ITextOf race) : base(race){}
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => ApplyConstitutionBonus(attribute);
        private IAttributeScore ApplyConstitutionBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Constitution) ? new AttributeScore(0) : new AttributeScore(2);
        public override ISpeed Speed() => new Speed(25);
        public override ISize Size() => Physical.Size.Medium;
        public override List<IProficiency> Proficiencies()
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
