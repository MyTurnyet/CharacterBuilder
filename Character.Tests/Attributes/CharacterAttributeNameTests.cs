using Character.Attributes;
using Character.Display;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Character.Tests.Attributes
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
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnNameObject()
        {
            //assign
            IAttributeName nameStr = CharacterAttributeName.Strength;

            //assert
            nameStr.Name().Should().Be(new TextObj("STR"));
        }

        
    }
}
