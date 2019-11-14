using System.Collections.Generic;
using Character.Attributes;
using Character.Display;
using Character.Physical;
using Character.Physical.Proficiencies;
using Character.Physical.Sizes;

namespace Character.Races
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
