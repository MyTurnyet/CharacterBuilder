using System.Collections.Generic;
using Characters.Attributes;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Physical.Sizes;

namespace Characters.Races
{
    public class Halfling:CharacterRace, ICharacterRace
    {
        protected Halfling(ITextObj race) : base(race)
        {
        }

        public virtual IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => !attribute.MatchesName(CharacterAttributeName.Dexterity) ? new AttributeScore(0) : new AttributeScore(2);
        public virtual ISpeed Speed() => new Speed(25);
        public override IHitPoints BonusHitPoints() => new HitPoints(0);
        public virtual ISize Size() => new Small();
        public virtual List<IProficiency> Proficiencies() => new List<IProficiency>();
    }
}
