using System.Collections.Generic;
using System.Linq;
using Characters.Display;

namespace Characters.Attributes
{
    public class AttributeSet : IAttributeSet
    {
        public AttributeSet()
        {
            _attributes.Add(new StrengthAttribute());
            _attributes.Add(new DexterityAttribute());
            _attributes.Add(new ConstitutionAttribute());
            _attributes.Add(new IntellegenceAttribute());
            _attributes.Add(new WisdomAttribute());
            _attributes.Add(new CharismaAttribute());

        }
        private readonly List<ICharacterAttribute> _attributes = new List<ICharacterAttribute>();
        public ICharacterAttribute MatchesName(IAttributeName attributeName) => GetAttributeFromName(attributeName);
        public ITextOf DisplayText()
        {
            TextOf displayText = new TextOf();
            GetAttributeFromName(CharacterAttributeName.Strength).DisplayText(displayText);
            return displayText;
        }

        public void SetAttribute(IAttributeName attName, IAttributeScore attributeScore)
        {
            _attributes.Remove(GetAttributeFromName(attName));
            _attributes.Add(new CharacterAttribute(attName,attributeScore));
        }

        private ICharacterAttribute GetAttributeFromName(IAttributeName name) => _attributes.First(arrib => arrib.MatchesName(name));

    }
}
