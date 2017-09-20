using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters.Attributes;

namespace Characters.Races
{
    public abstract class Dwarf:CharacterRace
    {
        public Dwarf(string race) : base(race){}

        public override ICharacterAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => ApplyConstitutionBonus(attribute);
        private ICharacterAttributeScore ApplyConstitutionBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Constitution) ? new CharacterAttributeScore(0) : new CharacterAttributeScore(2);
        public override Speed Speed() => new Speed(25);
    }
}
