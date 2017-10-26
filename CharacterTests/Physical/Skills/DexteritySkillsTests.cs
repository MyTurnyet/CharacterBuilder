using System;
using Characters.Attributes;
using Characters.Display;
using Characters.Physical.Skills;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical.Skills
{
    [TestClass]
    public class AcrobaticsTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //assign
            ISkill actualSkillBase = new Acrobatics();
            //act
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Acrobatics"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBaseAttribute()
        {
            //arrange
            ISkill acrobatics = new Acrobatics();
            ICharacterAttribute dexterityAttribute = new DexterityAttribute();
            //act
            ICharacterAttribute actualAttribute = acrobatics.BaseAttribute();

            //assert
            actualAttribute.Should().Be(dexterityAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            DexterityAttribute dexterityAttribute = new DexterityAttribute(new AttributeScore(14));
            ISkill acrobatics = new Acrobatics(dexterityAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = acrobatics.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
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
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Sleight Of Hand"));
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
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            DexterityAttribute dexterityAttribute = new DexterityAttribute(new AttributeScore(14));
            ISkill sleightOfHand = new SleightOfHand(dexterityAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = sleightOfHand.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
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
            ITextObj name = actualSkillBase.Name();
            //assert
            name.Should().Be(new TextObj("Stealth"));
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
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnBonusOfBaseAttribute()
        {
            //arrange
            DexterityAttribute dexterityAttribute = new DexterityAttribute(new AttributeScore(14));
            ISkill stealth = new Stealth(dexterityAttribute);
            IAttributeScore expectedScore = new AttributeScore(2);
            //act
            IAttributeScore actualScore = stealth.SkillBonus();

            //assert
            actualScore.Should().Be(expectedScore);
        }
    }

}
