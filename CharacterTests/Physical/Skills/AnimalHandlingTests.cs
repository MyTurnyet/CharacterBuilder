using System;
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
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Animal Handling"));
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
    public class ArcanaTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Arcana();
            //act
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Arcana"));
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
    public class AthleticsTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Athletics();
            //act
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Athletics"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWisdomAsBaseAttribute()
        {
            //arrange
            ISkill skill = new Athletics();
            ICharacterAttribute strengthAttribute = new StrengthAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(strengthAttribute);
        }

    }
    [TestClass]
    public class DeceptionTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Deception();
            //act
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Deception"));
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
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("History"));
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
    public class InsightTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Insight();
            //act
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Insight"));
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
    public class IntimidationTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Intimidation();
            //act
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Intimidation"));
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
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Investigation"));
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
    public class MedicineTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Medicine();
            //act
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Medicine"));
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
    public class NatureTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Nature();
            //act
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Nature"));
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
    [TestClass]
    public class PerceptionTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Perception();
            //act
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Perception"));
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
    public class PerformanceTests
    {

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Performance();
            //act
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Performance"));
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
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Persuasion"));
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
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Religion"));
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
    public class SleightOfHandTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new SleightOfHand();
            //act
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Sleight Of Hand"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBaseAttribute()
        {
            //arrange
            ISkill skill = new SleightOfHand();
            ICharacterAttribute dexterityAttribute = new DexterityAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(dexterityAttribute);
        }
    }

    [TestClass]
    public class StealthTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Stealth();
            //act
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Stealth"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBaseAttribute()
        {
            //arrange
            ISkill skill = new Stealth();
            ICharacterAttribute dexterityAttribute = new DexterityAttribute();
            //act
            ICharacterAttribute actualAttribute = skill.BaseAttribute();

            //assert
            actualAttribute.Should().Be(dexterityAttribute);
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
            ITextOf name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextOf("Survival"));
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
