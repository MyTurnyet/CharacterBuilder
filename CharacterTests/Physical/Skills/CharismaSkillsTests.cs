using Characters.Attributes;
using Characters.Display;
using Characters.Physical.Skills;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical.Skills
{
    [TestClass]
    public class DeceptionTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Deception();
            //act
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Deception"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWisdomAsBaseAttribute()
        {
            //arrange
            ISkill skill = new Deception();
            ICharacterAttribute charismaAttribute = new CharismaAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(charismaAttribute);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            CharismaAttribute charismaAttribute = new CharismaAttribute(new AttributeScore(14));
            ISkill deception = new Deception(charismaAttribute, false);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = deception.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
        }
    }

    [TestClass]
    public class IntimidationTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Intimidation();
            //act
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Intimidation"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBaseAttribute()
        {
            //arrange
            ISkill skill = new Intimidation();
            ICharacterAttribute charismaAttribute = new CharismaAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(charismaAttribute);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            CharismaAttribute dexterityAttribute = new CharismaAttribute(new AttributeScore(14));
            ISkill intimidation = new Intimidation(dexterityAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = intimidation.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
        }
    }

    [TestClass]
    public class PerformanceTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Performance();
            //act
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Performance"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBaseAttribute()
        {
            //arrange
            ISkill skill = new Performance();
            ICharacterAttribute charismaAttribute = new CharismaAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(charismaAttribute);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            CharismaAttribute dexterityAttribute = new CharismaAttribute(new AttributeScore(14));
            ISkill performance = new Performance(dexterityAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = performance.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
        }
    }
    [TestClass]
    public class PersuasionTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Persuasion();
            //act
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Persuasion"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBaseAttribute()
        {
            //arrange
            ISkill skill = new Persuasion();
            ICharacterAttribute charismaAttribute = new CharismaAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(charismaAttribute);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            CharismaAttribute dexterityAttribute = new CharismaAttribute(new AttributeScore(14));
            ISkill persuasion = new Persuasion(dexterityAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = persuasion.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
        }
    }

}