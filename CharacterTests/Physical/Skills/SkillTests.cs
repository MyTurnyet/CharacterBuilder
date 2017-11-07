using Characters.Attributes;
using Characters.Display;
using Characters.Physical.Skills;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical.Skills
{
    [TestClass]
    public class SkillTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //assign
            ISkill expectedSkillBase = new Acrobatics();
            ISkill actualSkillBase = new Acrobatics();

            //assert
            actualSkillBase.Should().Be(expectedSkillBase);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //assign
            ISkill expectedSkillBase = new Acrobatics();
            ISkill actualSkillBase = new Deception();

            //assert
            actualSkillBase.Should().NotBe(expectedSkillBase);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnInactiveSkillBonus()
        {
            //arrange
            ISkill expectedSkillBase = new Deception(new CharismaAttribute(new AttributeScore(14)),false );
            AttributeScore score = new AttributeScore(2);
            //act
            IAttributeScore actualScore = expectedSkillBase.SkillBonus();
            //assert
            actualScore.Should().Be(score);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnActiveSkillBonus()
        {
            //arrange
            ISkill expectedSkillBase = new Deception(new CharismaAttribute(new AttributeScore(14)),true );
            AttributeScore score = new AttributeScore(4);
            //act
            IAttributeScore actualScore = expectedSkillBase.SkillBonus();
            //assert
            actualScore.Should().Be(score);
        }
    }
}
