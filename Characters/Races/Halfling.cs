using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters.Attributes;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Physical.Sizes;

namespace Characters.Races
{
    public class Halfling:CharacterRace, ICharacterRace
    {
        public Halfling(ITextObj race) : base(race)
        {
        }

        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute)
        {
            return !attribute.MatchesName(CharacterAttributeName.Dexterity) ? new AttributeScore(0) : new AttributeScore(2);
        }

        public override ISpeed Speed()
        {
            throw new NotImplementedException();
        }

        public override IHitPoints BonusHitPoints()
        {
            throw new NotImplementedException();
        }

        public override ISize Size()
        {
            throw new NotImplementedException();
        }

        public override List<IProficiency> Proficiencies()
        {
            throw new NotImplementedException();
        }
    }
}
