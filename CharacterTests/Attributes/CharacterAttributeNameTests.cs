using Characters.Attributes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Attributes
{
    [TestClass]
    public class CharacterAttributeNameTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //assign
            IAttributeName nameStr = CharacterAttributeName.Strength;
            IAttributeName nameStr2 = CharacterAttributeName.Strength;
            
            //assert
            nameStr2.Should().Be(nameStr);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //assign
            IAttributeName nameStr = CharacterAttributeName.Strength;
            IAttributeName nameStr2 = CharacterAttributeName.Dexterity;
            
            //assert
            nameStr2.Should().NotBe(nameStr);
        }
    }
}
