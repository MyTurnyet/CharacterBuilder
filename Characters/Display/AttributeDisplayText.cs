using Characters.Attributes;

namespace Characters.Display
{
    public class AttributeDisplayText : TextOf, IAttributeDisplayText
    {
        private readonly CharacterAttribute _characterAttribute;
        public AttributeDisplayText(CharacterAttribute characterAttribute)
        {
            _characterAttribute = characterAttribute;
        }

        public ITextOf Text()
        {
            ITextOf textOf =_characterAttribute.DisplayText();
            return textOf;
        }
    }
}
