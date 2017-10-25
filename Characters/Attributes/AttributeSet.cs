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
        public ITextObj DisplayText()
        {
            return GetAttributeFromName(CharacterAttributeName.Strength).DisplayText()
                .Append(new NewLineTextObj())
                .Append(GetAttributeFromName(CharacterAttributeName.Dexterity).DisplayText());
        }

        public void SetAttribute(IAttributeName attName, IAttributeScore attributeScore)
        {
            _attributes.Remove(GetAttributeFromName(attName));
            _attributes.Add(new CharacterAttribute(attName,attributeScore));
        }

        private ICharacterAttribute GetAttributeFromName(IAttributeName name) => _attributes.First(arrib => arrib.MatchesName(name));

    }
}
