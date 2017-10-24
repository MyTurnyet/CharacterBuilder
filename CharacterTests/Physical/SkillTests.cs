using Characters.Display;
using Characters.Physical;
using Characters.Physical.Skills;
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
            SkillBase expectedSkillBase = new Acrobatics();
            SkillBase actualSkillBase = new Acrobatics();

            //assert
            actualSkillBase.Should().Be(expectedSkillBase);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //assign
            SkillBase expectedSkillBase = new Acrobatics();
            SkillBase actualSkillBase = new Deception();

            //assert
            actualSkillBase.Should().NotBe(expectedSkillBase);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            SkillBase actualSkillBase = new Deception();
            //act
            TextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Deception"));
        }
        
    }
}
