using Characters.Attributes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Attributes
{
    [TestClass]
    public class CharacterAttributeSetTests
    {
        private IAttributeSet _attributeSet;

        [TestInitialize]
        public void Setup()
        {
            _attributeSet = new AttributeSet();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnDexterityAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = CreateAttribute(CharacterAttributeName.Dexterity);
            //assert
            _attributeSet.Dexterity().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnStrengthAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = CreateAttribute(CharacterAttributeName.Strength);
            //assert
            _attributeSet.Strength().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnConstitutionAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = CreateAttribute(CharacterAttributeName.Constitution);
            //assert
            _attributeSet.Constitution().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnIntellegenceAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = CreateAttribute(CharacterAttributeName.Intelligence);
            //assert
            _attributeSet.Intellegence().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWisdomAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = CreateAttribute(CharacterAttributeName.Wisdom);
            //assert
            _attributeSet.Wisdom().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnCharismaAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = CreateAttribute(CharacterAttributeName.Charisma);
            //assert
            _attributeSet.Charisma().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldMatchName()
        {
            //assign
            ICharacterAttribute expectedAttribute = new CharacterAttribute(CharacterAttributeName.Strength, new AttributeScore(18));
            //act
            ICharacterAttribute actualAttribute = _attributeSet.MatchesName(CharacterAttributeName.Strength);
            //assert
            actualAttribute.Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldAddAttribute()
        {
            //arrange
            ICharacterAttribute expectedAttribute = new CharacterAttribute(CharacterAttributeName.Strength, new AttributeScore(18));
            //act
            _attributeSet.Strength().Set(expectedAttribute.Score());
            //assert
            _attributeSet.Strength().Score().Should().Be(expectedAttribute.Score());
        }
        private ICharacterAttribute CreateAttribute(IAttributeName attributeName) => new CharacterAttribute(attributeName, new AttributeScore(0));
    }
}
