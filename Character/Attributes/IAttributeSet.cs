using System.Text;
using Character.Display;

namespace Character.Attributes
{
    public interface IAttributeSet
    {
        ICharacterAttribute MatchesName(IAttributeName attributeName);
        ITextObj DisplayText();
        void SetAttribute(IAttributeName attName, IAttributeScore attributeScore);
        void AddJsonToStringbuilder(StringBuilder stringBuilder);
    }
}