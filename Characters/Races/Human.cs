using System.Collections.Generic;
using Characters.Attributes;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using Characters.Physical.Sizes;

namespace Characters.Races
{
    public class Human : CharacterRace
    {
        private readonly List<IProficiency> _proficiencies = new List<IProficiency>();
        private readonly AttributeScore _racialAttributeAdjustment = new AttributeScore(1);
        public Human() : base(new TextObj("Human")) { }
        public override IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute) => _racialAttributeAdjustment;
        public override ISpeed Speed() => new Speed(30);
        public override IHitPoints BonusHitPoints() => new HitPoints(0);
        public override ISize Size() => new Medium();
        public override List<IProficiency> Proficiencies() => _proficiencies;
    }
}
