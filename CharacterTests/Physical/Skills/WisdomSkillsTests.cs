using Characters.Attributes;
using Characters.Display;
using Characters.Physical.Skills;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical.Skills
{
    [TestClass]
    public class AnimalHandlingTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new AnimalHandling();
            //act
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Animal Handling"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBaseAttribute()
        {
            //arrange
            ISkill skill = new AnimalHandling();
            ICharacterAttribute wisdomAttribute = new WisdomAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(wisdomAttribute);
        }
    }
    [TestClass]
    public class InsightTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Insight();
            //act
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Insight"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWisdomAsBaseAttribute()
        {
            //arrange
            ISkill skill = new Insight();
            ICharacterAttribute wisdomAttribute = new WisdomAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(wisdomAttribute);
        }
    }
    [TestClass]
    public class MedicineTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Medicine();
            //act
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Medicine"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWisdomAsBaseAttribute()
        {
            //arrange
            ISkill skill = new Medicine();
            ICharacterAttribute wisdomAttribute = new WisdomAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(wisdomAttribute);
        }
    }
    [TestClass]
    public class PerceptionTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Perception();
            //act
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Perception"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWisdomAsBaseAttribute()
        {
            //arrange
            ISkill skill = new Perception();
            ICharacterAttribute wisdomAttribute = new WisdomAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(wisdomAttribute);
        }
    }

    [TestClass]
    public class SurvivalTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Survival();
            //act
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Survival"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWisdomAsBaseAttribute()
        {
            //arrange
            ISkill skill = new Survival();
            ICharacterAttribute wisdomAttribute = new WisdomAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(wisdomAttribute);
        }
    }
}