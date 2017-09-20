using Characters.Races;

namespace Characters.Attributes
{
    public class CharacterAttribute : ICharacterAttribute
    {
        private readonly ICharacterAttributeName _name;
        private ICharacterAttributeScore _value;
        private ICharacterAttributeScore _racialAttributeAdjustment = new CharacterAttributeScore(0);

        public CharacterAttribute(ICharacterAttributeName name, ICharacterAttributeScore value)
        {
            _name = name;
            _value = value;
        }
        public override bool Equals(object obj) => (CharacterAttribute)obj != null && ((CharacterAttribute)obj)._name == _name;
        public override int GetHashCode() => _name.GetHashCode();
        protected bool Equals(CharacterAttribute other) => _name.Equals(other._name);
        public static bool operator ==(CharacterAttribute left, CharacterAttribute right) => Equals(left, right);
        public static bool operator !=(CharacterAttribute left, CharacterAttribute right) => !Equals(left, right);
        public bool MatchesName(ICharacterAttributeName attributeName) => attributeName.Equals(_name);
        public CharacterAttributeScore Score() => BaseScore() + (CharacterAttributeScore)_racialAttributeAdjustment;
        private CharacterAttributeScore BaseScore() => (CharacterAttributeScore)_value;
        public void ApplyRacialBonus(CharacterRace race) => _racialAttributeAdjustment = race.RacialAttributeAdjustment(this);
        public void Set(CharacterAttributeScore score)
        {
            _value = score;
        }
    }
}
