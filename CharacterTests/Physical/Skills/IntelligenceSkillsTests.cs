using Characters.Attributes;
using Characters.Display;
using Characters.Physical.Skills;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical.Skills
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
    }

}