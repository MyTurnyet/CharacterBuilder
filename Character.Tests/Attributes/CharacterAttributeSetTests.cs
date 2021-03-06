﻿using System.Text;
using Character.Attributes;
using Character.Display;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Character.Tests.Attributes
{
    [TestClass]
    public class CharacterAttributeSetTests
    {
        private IAttributeSet _attributeSet;

        [TestInitialize]
        public void Setup()
        {
            _attributeSet = new EmptyAttributeSet();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnDexterityAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = new DexterityAttribute();
            //assert
            _attributeSet.MatchesName(CharacterAttributeName.Dexterity).Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnStrengthAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = new StrengthAttribute();
            //assert
            _attributeSet.MatchesName(CharacterAttributeName.Strength).Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnConstitutionAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = new ConstitutionAttribute();
            //assert
            _attributeSet.MatchesName(CharacterAttributeName.Constitution).Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnIntellegenceAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = new IntellegenceAttribute();
            //assert
            _attributeSet.MatchesName(CharacterAttributeName.Intelligence).Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWisdomAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = new WisdomAttribute();
            //assert
            _attributeSet.MatchesName(CharacterAttributeName.Wisdom).Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnCharismaAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = new CharismaAttribute();
            //assert
            _attributeSet.MatchesName(CharacterAttributeName.Charisma).Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldMatchName()
        {
            //assign
            ICharacterAttribute expectedAttribute = new StrengthAttribute(new AttributeScore(18));
            //act
            ICharacterAttribute actualAttribute = _attributeSet.MatchesName(CharacterAttributeName.Strength);
            //assert
            actualAttribute.Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldAddAttribute()
        {
            //arrange
            ICharacterAttribute expectedAttribute = new StrengthAttribute(new AttributeScore(18));
            //act
            _attributeSet.MatchesName(CharacterAttributeName.Strength).Set(expectedAttribute.Score());
            //assert
            _attributeSet.MatchesName(CharacterAttributeName.Strength).Score().Should().Be(expectedAttribute.Score());
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnTextOfStats()
        {
            //TODO: add all stats
            //assign
            ITextObj expectedtTextObj = new TextObj("STR: 11\r\nDEX: 0\r\nCON: 0\r\nINT: 0");
            _attributeSet.SetAttribute(CharacterAttributeName.Strength, new AttributeScore(11));
            //act
            ITextObj actualTextObj = _attributeSet.DisplayText();
            //assert
            actualTextObj.Should().Be(expectedtTextObj);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnJsonObject()
        {
            //arrange
            string expectedJson = "\"characterAttributes\":[{\"characterAttribute\":\"STR\",\"value\":0},{\"characterAttribute\":\"DEX\",\"value\":0},{\"characterAttribute\":\"CON\",\"value\":0},{\"characterAttribute\":\"INT\",\"value\":0},{\"characterAttribute\":\"WIS\",\"value\":0},{\"characterAttribute\":\"CHR\",\"value\":0},]";
            
            StringBuilder sb = new StringBuilder();
            //act
            _attributeSet.AddJsonToStringbuilder(sb);
            //assert
            sb.ToString().Should().Be(expectedJson);
        }

    }
}
