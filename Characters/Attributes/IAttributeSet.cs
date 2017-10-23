using Characters.Display;

namespace Characters.Attributes
{
    public interface IAttributeSet
    {
        ICharacterAttribute MatchesName(IAttributeName attributeName);
        ITextOf DisplayText();
        void SetAttribute(IAttributeName attName, IAttributeScore attributeScore);
    }
}