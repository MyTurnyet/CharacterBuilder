using System;

namespace Characters.Attributes
{
    public class AttributeScore : IAttributeScore
    {
        private readonly int _value;

        public AttributeScore(int value)
        {
            _value = value;
        }

        public override bool Equals(object obj) => (AttributeScore)obj != null && Equals((AttributeScore)obj);
        private bool Equals(AttributeScore other) => _value == other._value;
        public override int GetHashCode() => _value;
        public static AttributeScore operator +(AttributeScore left, AttributeScore right) => new AttributeScore(left._value + right._value);
        public static AttributeScore operator -(AttributeScore left, AttributeScore right) => new AttributeScore(left._value - right._value);
        public int Bonus() => (int)Math.Floor((decimal)(_value - 10) / 2);
    }
}
