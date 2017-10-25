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

        public new ITextObj Text()
        {
            ITextObj textObj =_characterAttribute.DisplayText();
            return textObj;
        }
    }
}
