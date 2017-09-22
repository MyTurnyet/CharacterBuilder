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

        public override bool Equals(object obj)
        {
            return (AttributeScore)obj != null && ((AttributeScore)obj)._value == _value;
        }

        protected bool Equals(AttributeScore other)
        {
            return _value == other._value;
        }

        public override int GetHashCode()
        {
            return _value;
        }

        public static bool operator ==(AttributeScore left, AttributeScore right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AttributeScore left, AttributeScore right)
        {
            return !Equals(left, right);
        }
        public static AttributeScore operator +(AttributeScore left, AttributeScore right)
        {
            return new AttributeScore(left._value + right._value);
        }
        public static AttributeScore operator -(AttributeScore left, AttributeScore right)
        {
            return new AttributeScore(left._value - right._value);
        }

        public static AttributeScore operator +(AttributeScore left, int right)
        {
            return new AttributeScore(left._value + right);
        }
        public static AttributeScore operator -(AttributeScore left, int right)
        {
            return new AttributeScore(left._value - right);
        }
        public static AttributeScore operator /(AttributeScore left, int right)
        {
            // ReSharper disable once PossibleLossOfFraction
            decimal d = (left._value / right);
            int score = (int)Math.Round(d,0, MidpointRounding.AwayFromZero);
            return new AttributeScore(score);
        }
    }
}
