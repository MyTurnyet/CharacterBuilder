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
        //[TestMethod, TestCategory("Unit")]
        //public void ShouldReturnName()
        //{
        //    //assign
        //    ISkill actualSkillBase = new Deception();
        //    //act
        //    ITextOf name = actualSkillBase.Name();
        //    //assert
        //    name.Should().Be(new TextOf("Deception"));
        //}

        //[TestMethod, TestCategory("Unit")]
        //public void ShouldReturnWisdomAsBaseAttribute()
        //{
        //    //arrange
        //    ISkill deception = new Deception();
        //    ICharacterAttribute charisma = new CharismaAttribute();
        //    //act
        //    ICharacterAttribute actualAttribute = deception.BaseAttribute();

        //    //assert
        //    actualAttribute.Should().Be(charisma);
        //}
        
    }
}
