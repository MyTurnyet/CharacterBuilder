﻿using System.Text;
using Character.Attributes;
using Character.Races;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Character.Tests.Attributes
{
    [TestClass]
    public class CharacterAttributeTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquateName()
        {
            //assign
            ICharacterAttribute attribute = new StrengthAttribute(new AttributeScore(18));
            ICharacterAttribute attribute2 = new DexterityAttribute( new AttributeScore(18));

            //assert
            attribute2.Should().NotBe(attribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldEquateName()
        {
            //assign
            ICharacterAttribute attribute = new StrengthAttribute(new AttributeScore(18));
            ICharacterAttribute attribute2 = new StrengthAttribute(new AttributeScore(5));

            //assert
            attribute2.Should().Be(attribute);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldMatchName()
        {
            //assign
            ICharacterAttribute attribute = new StrengthAttribute(new AttributeScore(18));
            //act
            bool matchesName = attribute.MatchesName(CharacterAttributeName.Strength);
            //assert
            matchesName.Should().BeTrue();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotMatchName()
        {
            //assign
            ICharacterAttribute attribute = new StrengthAttribute(new AttributeScore(18));
            //act
            bool matchesName = attribute.MatchesName(CharacterAttributeName.Dexterity);
            //assert
            matchesName.Should().BeFalse();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldApplyRacialAttributeBonus()
        {
            //arrange
            ICharacterAttribute attribute = new DexterityAttribute(new AttributeScore(10));
            //act
            attribute.ApplyRacialBonus(CharacterRace.Human);
            //assert
            attribute.Score().Should().Be(new AttributeScore(11));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldSetScore()
        {
            //arrange
            ICharacterAttribute attribute = new DexterityAttribute(new AttributeScore(10));
            IAttributeScore expectedScore = new AttributeScore(14);
            //act
            attribute.Set(expectedScore);
            //assert
            attribute.Score().Should().Be(expectedScore);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnAttributeBonus()
        {
            //arrange
            ICharacterAttribute attribute = new DexterityAttribute(new AttributeScore(1));
            IAttributeScore expectedAttributeBonus = new AttributeScore(-5);

            //act
            IAttributeScore actualAttributeBonus = attribute.Bonus();

            //assert
            actualAttributeBonus.Should().Be(expectedAttributeBonus);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnJsonObject()
        {
            //arrange
            ICharacterAttribute attribute = new DexterityAttribute(new AttributeScore(10));
            IAttributeScore expectedScore = new AttributeScore(14);
            string expectedJson = "{\"characterAttribute\":\"DEX\",\"value\":10}";
            StringBuilder sb = new StringBuilder();
            //act
            attribute.AddJsonToStringbuilder(sb);
            //assert
            sb.ToString().Should().Be(expectedJson);
        }
    }
}
