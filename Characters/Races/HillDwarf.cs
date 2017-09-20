using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters.Attributes;

namespace Characters.Races
{
    public class HillDwarf:Dwarf
    {
        public HillDwarf() : base("Hill Dwarf"){}
        public override ICharacterAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => (CharacterAttributeScore)base.RacialAttributeAdjustment(attribute) + ApplyWisdomBonus(attribute);
        private CharacterAttributeScore ApplyWisdomBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Wisdom) ? new CharacterAttributeScore(0) : new CharacterAttributeScore(1);
    }
}
