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
    }
}
