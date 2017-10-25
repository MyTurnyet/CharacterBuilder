using System.Collections.Generic;
using System.Linq;
using Characters.Attributes;
using Characters.Display;

namespace CharacterTests.Fakes
{
    public class FakeAttributeSet : IAttributeSet
    {
         List<ICharacterAttribute> attributes = new List<ICharacterAttribute>
         {
             new StrengthAttribute(), new DexterityAttribute(), new ConstitutionAttribute(),
             new WisdomAttribute(), new IntellegenceAttribute(), new CharismaAttribute()
         };
        public ICharacterAttribute MatchesName(IAttributeName attributeName)
        {
            return attributes.FirstOrDefault(att => att.MatchesName(attributeName));
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
