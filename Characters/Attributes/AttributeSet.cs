using System.Collections.Generic;
using System.Linq;
using System.Text;
using Characters.Display;

namespace Characters.Attributes
{
    public class AttributeSet : IAttributeSet
    {
        public AttributeSet() : this(0, 0, 0, 0, 0, 0)
        {
        }

        public AttributeSet(int strength , int dexterity, int intellegence, int constitution, int wisdom, int charisma)
        {
            _attributes.Add(new StrengthAttribute(new AttributeScore(strength)));
            _attributes.Add(new DexterityAttribute(new AttributeScore(dexterity)));
            _attributes.Add(new ConstitutionAttribute(new AttributeScore(intellegence)));
            _attributes.Add(new IntellegenceAttribute(new AttributeScore(constitution)));
            _attributes.Add(new WisdomAttribute(new AttributeScore(wisdom)));
            _attributes.Add(new CharismaAttribute(new AttributeScore(charisma)));

        }
        private readonly List<ICharacterAttribute> _attributes = new List<ICharacterAttribute>();
        public ICharacterAttribute MatchesName(IAttributeName attributeName) => GetAttributeFromName(attributeName);
        public ITextObj DisplayText()
        {
            return GetAttributeFromName(CharacterAttributeName.Strength).DisplayText()
                .Append(new NewLineTextObj())
                .Append(GetAttributeFromName(CharacterAttributeName.Dexterity).DisplayText())
                .Append(new NewLineTextObj())
                .Append(GetAttributeFromName(CharacterAttributeName.Constitution).DisplayText())
                .Append(new NewLineTextObj())
                .Append(GetAttributeFromName(CharacterAttributeName.Intelligence).DisplayText());
        }

        public void SetAttribute(IAttributeName attName, IAttributeScore attributeScore)
        {
            _attributes.Remove(GetAttributeFromName(attName));
            _attributes.Add(new CharacterAttribute(attName, attributeScore));
        }

        public void AddJsonToStringbuilder(StringBuilder stringBuilder)
        {
            stringBuilder.Append("\"characterAttributes\":[");
            foreach (ICharacterAttribute attribute in _attributes)
            {
                attribute.AddJsonToStringbuilder(stringBuilder);
                stringBuilder.Append(",");

            }
            stringBuilder.Append("]");
        }

        private ICharacterAttribute GetAttributeFromName(IAttributeName name) => _attributes.First(arrib => arrib.MatchesName(name));

    }
}
