using Characters.Physical;
using Characters.Races;

namespace Characters.Attributes
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class CharacterAttribute : ICharacterAttribute

    {
        private readonly IAttributeName _name;
        private IAttributeScore _value;
        private IAttributeScore _racialAttributeAdjustment = new AttributeScore(0);

        public CharacterAttribute(IAttributeName name, IAttributeScore value)
        {
            _name = name;
            _value = value;
        }
        public override bool Equals(object obj) => (CharacterAttribute)obj != null && ((CharacterAttribute)obj)._name == _name;
        public bool MatchesName(IAttributeName attributeName) => attributeName.Equals(_name);
        public AttributeScore Score() => BaseScore() + (AttributeScore)_racialAttributeAdjustment;
        private AttributeScore BaseScore() => (AttributeScore)_value;
        public void ApplyRacialBonus(CharacterRace race) => _racialAttributeAdjustment = race.RacialAttributeAdjustment(this);
        public void Set(AttributeScore score) => _value = score;
        public AttributeScore Bonus() => new AttributeScore(Score().Bonus());
        public HitPoints BonusHitPoints() => new HitPoints(Score().Bonus());
    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
