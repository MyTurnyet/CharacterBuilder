using Characters.Physical;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical
{
    [TestClass]
    public class SkillTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //assign
            Skill expectedSkill = Skill.Acrobatics;
            Skill actualSkill = Skill.Acrobatics;

            //assert
            actualSkill.Should().Be(expectedSkill);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //assign
            Skill expectedSkill = Skill.Acrobatics;
            Skill actualSkill = Skill.Deception;

            //assert
            actualSkill.Should().NotBe(expectedSkill);
        }

    }
}
