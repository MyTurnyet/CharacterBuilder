using System;
using Characters.Display;

namespace Characters.Attributes
{
#pragma warning disable 659
    public class AttributeScore : IAttributeScore
    {
        private readonly int _value;
        public AttributeScore(int value)
        {
            _value = value;
        }
        public override bool Equals(object obj) => (AttributeScore)obj != null && Equals((AttributeScore)obj);
        private bool Equals(AttributeScore other) => _value == other._value;
        public int Bonus() => (int)Math.Floor((decimal)(_value - 10) / 2);
        public TextObj AsText() => new TextObj(_value);
        public IAttributeScore Add(IAttributeScore scoreToAdd) => new AttributeScore(_value + ((AttributeScore)scoreToAdd)._value);
        public IAttributeScore Subtract(IAttributeScore scoreToSubtract) => new AttributeScore(_value - ((AttributeScore)scoreToSubtract)._value);
    }
#pragma warning restore 659
}
