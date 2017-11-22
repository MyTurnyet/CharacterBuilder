using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters.Attributes;
using Characters.Display;

namespace Characters.Races
{
    public class HalflingStout:Halfling
    {
        public HalflingStout() : base(new TextObj("Stout Halfling")){}
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => base.RacialAttributeAdjustment(attribute).Add(GetConstitutionBonus(attribute));
        private IAttributeScore GetConstitutionBonus(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Constitution) ? new AttributeScore(0) : new AttributeScore(1);
    }
}
