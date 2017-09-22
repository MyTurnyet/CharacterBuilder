using Characters;
using Characters.Attributes;
using Characters.Classes;
using Characters.Physical;
using Characters.Races;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests
{
    [TestClass]
    public class CharacterSheetTests
    {
        private ICharacterSheet _characterSheet;
        private IAttributeSet _attributeSet;
        private ICharacterAttribute _strAttribute;
        private ICharacterAttribute _dexAttribute;
        private ICharacterAttribute _conAttribute;
        private ICharacterAttribute _intAttribute;
        private ICharacterAttribute _wizAttribute;
        private ICharacterAttribute _chrAttribute;

        [TestInitialize]
        public void Setup()
        {
            SetupAttributes();
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquateAttributes()
        {
            //assign
            _characterSheet = new CharacterSheet(CharacterClass.Fighter, CharacterRace.WoodElf, _attributeSet);
           
            //act
            ICharacterAttribute actualAttribute = _characterSheet.Attribute(CharacterAttributeName.Dexterity);
            //assert
            actualAttribute.Should().Be(_dexAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldApplyRacialBonusToAttributes()
        {
            //arrange
            AttributeScore expectedDexterityScore = new AttributeScore(12);
            AttributeScore expectedWisdomScore = new AttributeScore(9);
            _characterSheet = new CharacterSheet(CharacterClass.Fighter, CharacterRace.WoodElf, _attributeSet);
            //assert
            _characterSheet.Attribute(CharacterAttributeName.Strength).Score().Should().Be(_strAttribute.Score());
            
            _characterSheet.Attribute(CharacterAttributeName.Dexterity).Score().Should().Be(expectedDexterityScore);
            _characterSheet.Attribute(CharacterAttributeName.Constitution).Score().Should().Be(_conAttribute.Score());
            _characterSheet.Attribute(CharacterAttributeName.Intelligence).Score().Should().Be(_intAttribute.Score());
            _characterSheet.Attribute(CharacterAttributeName.Wisdom).Score().Should().Be(expectedWisdomScore);
            _characterSheet.Attribute(CharacterAttributeName.Charisma).Score().Should().Be(_chrAttribute.Score());
        }

        //[TestMethod, TestCategory("Unit")]
        //public void ShouldReturnStartingHitPoints()
        //{
        //    //arrange
        //    HitPoints expectedHitPoints = new HitPoints(14);
        //    //act

        //    //assert
        //}
        #region Helper Methods
        private void SetupAttributes()
        {
            _strAttribute = new CharacterAttribute(CharacterAttributeName.Strength, new AttributeScore(16));
            _dexAttribute = new CharacterAttribute(CharacterAttributeName.Dexterity, new AttributeScore(10));
            _conAttribute = new CharacterAttribute(CharacterAttributeName.Constitution, new AttributeScore(13));
            _intAttribute = new CharacterAttribute(CharacterAttributeName.Intelligence, new AttributeScore(14));
            _wizAttribute = new CharacterAttribute(CharacterAttributeName.Wisdom, new AttributeScore(8));
            _chrAttribute = new CharacterAttribute(CharacterAttributeName.Charisma, new AttributeScore(6));
            _attributeSet = new AttributeSet();
            _attributeSet.Strength().Set(_strAttribute.Score());
            _attributeSet.Dexterity().Set(_dexAttribute.Score());
            _attributeSet.Constitution().Set(_conAttribute.Score());
            _attributeSet.Intellegence().Set(_intAttribute.Score());
            _attributeSet.Wisdom().Set(_wizAttribute.Score());
            _attributeSet.Charisma().Set(_chrAttribute.Score());

        }
        #endregion Helper Methods
    }
}
