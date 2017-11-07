using System.Collections.Generic;
using System.Linq;
using Characters.Attributes;
using Characters.Display;

namespace CharacterTests.Fakes
{
    public class FakeAttributeSet : IAttributeSet
    {
        readonly List<ICharacterAttribute> _attributes = new List<ICharacterAttribute>
         {
             new StrengthAttribute(new AttributeScore(10)), new DexterityAttribute(new AttributeScore(10)), new ConstitutionAttribute(new AttributeScore(10)),
             new WisdomAttribute(new AttributeScore(10)), new IntellegenceAttribute(new AttributeScore(10)), new CharismaAttribute(new AttributeScore(10))
         };
        public ICharacterAttribute MatchesName(IAttributeName attributeName)
        {
            return _attributes.FirstOrDefault(att => att.MatchesName(attributeName));
        }

        public ITextObj DisplayText()
        {
            return new TextObj("This Works!");
        }

        public void SetAttribute(IAttributeName attName, IAttributeScore attributeScore)
        {
            throw new System.NotImplementedException();
        }
    }
    public class FakeWizardAttributeSet : IAttributeSet
    {
        readonly List<ICharacterAttribute> _attributes = new List<ICharacterAttribute>
        {
            new StrengthAttribute(new AttributeScore(10)), new DexterityAttribute(new AttributeScore(10)), new ConstitutionAttribute(new AttributeScore(10)),
            new WisdomAttribute(new AttributeScore(14)), new IntellegenceAttribute(new AttributeScore(10)), new CharismaAttribute(new AttributeScore(10))
        };
        public ICharacterAttribute MatchesName(IAttributeName attributeName)
        {
            return _attributes.FirstOrDefault(att => att.MatchesName(attributeName));
        }

        public ITextObj DisplayText()
        {
            return new TextObj("This Works!");
        }

        public void SetAttribute(IAttributeName attName, IAttributeScore attributeScore)
        {
            throw new System.NotImplementedException();
        }
    }

}
