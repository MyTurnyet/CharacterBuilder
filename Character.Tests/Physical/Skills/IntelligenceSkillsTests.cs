using Character.Attributes;
using Character.Display;
using Character.Physical.Skills;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Character.Tests.Physical.Skills
{
    [TestClass]
    public class ArcanaTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Arcana();
            //act
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Arcana"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWisdomAsBaseAttribute()
        {
            //arrange
            ISkill skill = new Arcana();
            ICharacterAttribute intellegenceAttribute = new IntellegenceAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(intellegenceAttribute);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            IntellegenceAttribute intellegenceAttribute = new IntellegenceAttribute(new AttributeScore(14));
            ISkill arcana = new Arcana(intellegenceAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = arcana.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
        }
    }

    [TestClass]
    public class HistoryTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new History();
            //act
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("History"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWisdomAsBaseAttribute()
        {
            //arrange
            ISkill skill = new History();
            ICharacterAttribute intellegenceAttribute = new IntellegenceAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(intellegenceAttribute);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            IntellegenceAttribute intellegenceAttribute = new IntellegenceAttribute(new AttributeScore(14));
            ISkill history = new History(intellegenceAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = history.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
        }
    }
    [TestClass]
    public class ReligionTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Religion();
            //act
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Religion"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWisdomAsBaseAttribute()
        {
            //arrange
            ISkill skill = new Religion();
            ICharacterAttribute intellegenceAttribute = new IntellegenceAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(intellegenceAttribute);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            IntellegenceAttribute intellegenceAttribute = new IntellegenceAttribute(new AttributeScore(14));
            ISkill religion = new Religion(intellegenceAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = religion.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
        }
    }
    [TestClass]
    public class InvestigationTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Investigation();
            //act
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Investigation"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWisdomAsBaseAttribute()
        {
            //arrange
            ISkill skill = new Investigation();
            ICharacterAttribute intellegenceAttribute = new IntellegenceAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(intellegenceAttribute);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            IntellegenceAttribute intellegenceAttribute = new IntellegenceAttribute(new AttributeScore(14));
            ISkill investigation = new Investigation(intellegenceAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = investigation.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
        }
    }

    [TestClass]
    public class NatureTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Nature();
            //act
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Nature"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWisdomAsBaseAttribute()
        {
            //arrange
            ISkill skill = new Nature();
            ICharacterAttribute intellegenceAttribute = new IntellegenceAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(intellegenceAttribute);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            IntellegenceAttribute intellegenceAttribute = new IntellegenceAttribute(new AttributeScore(14));
            ISkill nature = new Nature(intellegenceAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = nature.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
        }
    }

}