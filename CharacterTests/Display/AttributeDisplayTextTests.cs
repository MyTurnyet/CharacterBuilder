using Characters.Attributes;
using Characters.Display;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Display
{
    [TestClass]
    public class AttributeDisplayTextTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnAttributeDisplayText()
        {
            //assign
            CharacterAttribute characterAttribute = 
                new CharacterAttribute(CharacterAttributeName.Strength, new AttributeScore());
            ITextObj expectedTextObj = new TextObj("STR: 0");
            //act
            AttributeDisplayText actualDisplayText = new AttributeDisplayText(characterAttribute);

            //assert
            actualDisplayText.Text().Should().Be(expectedTextObj);
        }

    }
}
