namespace Characters.Attributes
{
    public class CharacterAttributeScore : ICharacterAttributeScore
    {
        private readonly int _value;

        public CharacterAttributeScore(int value)
        {
            _value = value;
        }

        public override bool Equals(object obj)
        {
            return (CharacterAttributeScore)obj != null && ((CharacterAttributeScore)obj)._value == _value;
        }

        protected bool Equals(CharacterAttributeScore other)
        {
            return _value == other._value;
        }

        public override int GetHashCode()
        {
            return _value;
        }

        public static bool operator ==(CharacterAttributeScore left, CharacterAttributeScore right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CharacterAttributeScore left, CharacterAttributeScore right)
        {
            return !Equals(left, right);
        }
        public static CharacterAttributeScore operator +(CharacterAttributeScore left, CharacterAttributeScore right)
        {
            return new CharacterAttributeScore(left._value + right._value);
        }
        public static CharacterAttributeScore operator -(CharacterAttributeScore left, CharacterAttributeScore right)
        {
            return new CharacterAttributeScore(left._value - right._value);
        }

        public static CharacterAttributeScore operator +(CharacterAttributeScore left, int right)
        {
            return new CharacterAttributeScore(left._value + right);
        }
        public static CharacterAttributeScore operator -(CharacterAttributeScore left, int right)
        {
            return new CharacterAttributeScore(left._value - right);
        }
    }
}
