using System.Collections.Generic;
using Characters.Attributes;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Physical.Sizes;

namespace Characters.Races
{
    public class Human : CharacterRace, ICharacterRace
    {
        private readonly List<IProficiency> _proficiencies = new List<IProficiency>();
        private readonly AttributeScore _racialAttributeAdjustment = new AttributeScore(1);
        public Human() : base(new TextObj("Human")) { }
        public virtual IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => _racialAttributeAdjustment;
        public virtual ISpeed Speed() => new Speed(30);
        public override IHitPoints BonusHitPoints() => new HitPoints(0);
        public virtual ISize Size() => new Medium();
        public virtual List<IProficiency> Proficiencies() => _proficiencies;
        
    }
}
