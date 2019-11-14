using Character.Attributes;
using Character.Display;
using Character.Physical.Skills;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Character.Tests.Physical.Skills
{
    [TestClass]
    public class AthleticsTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Athletics();
            //act
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Athletics"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWisdomAsBaseAttribute()
        {
            //arrange
            ISkill skill = new Athletics();
            ICharacterAttribute strengthAttribute = new StrengthAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(strengthAttribute);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            StrengthAttribute strengthAttribute = new StrengthAttribute(new AttributeScore(14));
            ISkill athletics = new Athletics(strengthAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = athletics.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
        }
    }
}
