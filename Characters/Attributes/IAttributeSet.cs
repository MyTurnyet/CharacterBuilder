using System.Text;
using Characters.Display;

namespace Characters.Attributes
{
    public interface IAttributeSet
    {
        ICharacterAttribute MatchesName(IAttributeName attributeName);
        ITextObj DisplayText();
        void SetAttribute(IAttributeName attName, IAttributeScore attributeScore);
        void AddJsonToStringbuilder(StringBuilder stringBuilder);
    }
}