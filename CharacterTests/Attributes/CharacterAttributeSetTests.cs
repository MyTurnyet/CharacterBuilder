using Characters.Attributes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Attributes
{
    [TestClass]
    public class CharacterAttributeSetTests
    {
        private ICharacterAttributeSet _characterAttributeSet;

        [TestInitialize]
        public void Setup()
        {
            _characterAttributeSet = new CharacterAttributeSet();
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnDexterityAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = CreateAttribute(CharacterAttributeName.Dexterity);
            //assert
            _characterAttributeSet.Dexterity().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnStrengthAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = CreateAttribute(CharacterAttributeName.Strength);
            //assert
            _characterAttributeSet.Strength().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnConstitutionAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = CreateAttribute(CharacterAttributeName.Constitution);
            //assert
            _characterAttributeSet.Constitution().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnIntellegenceAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = CreateAttribute(CharacterAttributeName.Intelligence);
            //assert
            _characterAttributeSet.Intellegence().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWisdomAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = CreateAttribute(CharacterAttributeName.Wisdom);
            //assert
            _characterAttributeSet.Wisdom().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnCharismaAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = CreateAttribute(CharacterAttributeName.Charisma);
            //assert
            _characterAttributeSet.Charisma().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldMatchName()
        {
            //assign
            ICharacterAttribute expectedAttribute = new CharacterAttribute(CharacterAttributeName.Strength, new CharacterAttributeScore(18));
            //act
            ICharacterAttribute actualAttribute = _characterAttributeSet.MatchesName(CharacterAttributeName.Strength);
            //assert
            actualAttribute.Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldAddAttribute()
        {
            //arrange
            ICharacterAttribute expectedAttribute = new CharacterAttribute(CharacterAttributeName.Strength, new CharacterAttributeScore(18));
            //act
            _characterAttributeSet.Strength().Set(expectedAttribute.Score());
            //assert
            _characterAttributeSet.Strength().Score().Should().Be(expectedAttribute.Score());
        }
        private ICharacterAttribute CreateAttribute(ICharacterAttributeName attributeName) => new CharacterAttribute(attributeName, new CharacterAttributeScore(0));
    }
}
