﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Character.Attributes;
using Character.Display;

namespace Character.Tests.Fakes
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
            throw new NotImplementedException();
        }

        public void AddJsonToStringbuilder(StringBuilder stringBuilder)
        {
            throw new NotImplementedException();
        }
    }
    public class FakeWizardAttributeSet : IAttributeSet
    {
        readonly List<ICharacterAttribute> _attributes = new List<ICharacterAttribute>
        {
            new StrengthAttribute(new AttributeScore(10)), new DexterityAttribute(new AttributeScore(8)), new ConstitutionAttribute(new AttributeScore(10)),
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
            throw new NotImplementedException();
        }

        public void AddJsonToStringbuilder(StringBuilder stringBuilder)
        {
            stringBuilder.Append("\"characterAttributes\":[");
            foreach (ICharacterAttribute attribute in _attributes)
            {
                attribute.AddJsonToStringbuilder(stringBuilder);
            }
            stringBuilder.Append("]");
        }
    }

}
