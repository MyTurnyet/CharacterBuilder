using System.Collections.Generic;
using Characters.Attributes;
using Characters.Physical;

namespace Characters.Races
{
    public abstract class Dwarf:CharacterRace
    {
        protected Dwarf(TextOf race) : base(race){}
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => ApplyConstitutionBonus(attribute);
        private IAttributeScore ApplyConstitutionBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Constitution) ? new AttributeScore(0) : new AttributeScore(2);
        public override ISpeed Speed() => new Speed(25);
        public override Size Size() => Physical.Size.Medium;
        public override List<Proficiency> Proficiencies()
        {
            return new List<Proficiency>
            {
                Proficiency.Battleaxe,
                Proficiency.Handaxe,
                Proficiency.ThrowingHammer,
                Proficiency.Warhammer,
                Proficiency.BrewersSupplies,
                Proficiency.MasonsTools,
                Proficiency.SmithsTools
            };
        }
    }
}
