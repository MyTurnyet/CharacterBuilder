using Characters.Attributes;

namespace Characters.Display
{
    public class AttributeDisplayText : TextObj, IAttributeDisplayText
    {
        private readonly CharacterAttribute _characterAttribute;
        public AttributeDisplayText(CharacterAttribute characterAttribute)
        {
            _characterAttribute = characterAttribute;
        }
        public ITextObj Text() => _characterAttribute.DisplayText();
    }
}
