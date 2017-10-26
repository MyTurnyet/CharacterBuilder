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
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            WisdomAttribute wisdomAttribute = new WisdomAttribute(new AttributeScore(14));
            ISkill animalHandling = new AnimalHandling(wisdomAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = animalHandling.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
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
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            WisdomAttribute wisdomAttribute = new WisdomAttribute(new AttributeScore(14));
            ISkill insight = new Insight(wisdomAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = insight.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
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
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            WisdomAttribute wisdomAttribute = new WisdomAttribute(new AttributeScore(14));
            ISkill medicine = new Medicine(wisdomAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = medicine.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
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
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            WisdomAttribute wisdomAttribute = new WisdomAttribute(new AttributeScore(14));
            ISkill perception = new Perception(wisdomAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = perception.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
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
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            WisdomAttribute wisdomAttribute = new WisdomAttribute(new AttributeScore(14));
            ISkill survival = new Survival(wisdomAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = survival.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
        }
    }
}