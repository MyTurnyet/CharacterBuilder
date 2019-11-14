using System.Collections.Generic;
using System.Linq;
using System.Text;
using Character.Display;

namespace Character.Attributes
{
    public class AttributeSet : IAttributeSet
    {
        protected AttributeSet(int strength, int dexterity, int constitution, int intellegence, int wisdom, int charisma) :
            this(new AttributeScore(strength), new AttributeScore(dexterity), new AttributeScore(constitution),
                new AttributeScore(intellegence), new AttributeScore(wisdom), new AttributeScore(charisma)){}

        public AttributeSet(IAttributeScore strScore, IAttributeScore dexScore, IAttributeScore consScore, IAttributeScore intScore, IAttributeScore wisScore, IAttributeScore chrScore)
        {
            _attributes.Add(new StrengthAttribute(strScore));
            _attributes.Add(new DexterityAttribute(dexScore));
            _attributes.Add(new ConstitutionAttribute(consScore));
            _attributes.Add(new IntellegenceAttribute(intScore));
            _attributes.Add(new WisdomAttribute(wisScore));
            _attributes.Add(new CharismaAttribute(chrScore));

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
