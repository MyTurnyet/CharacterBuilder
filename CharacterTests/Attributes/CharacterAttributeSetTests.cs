using Characters;
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
            ICharacterAttribute expectedAttribute = new DexterityAttribute();
            //assert
            _attributeSet.Dexterity().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnStrengthAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = new StrengthAttribute();
            //assert
            _attributeSet.Strength().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnConstitutionAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = new ConstitutionAttribute();
            //assert
            _attributeSet.Constitution().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnIntellegenceAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = new IntellegenceAttribute();
            //assert
            _attributeSet.Intellegence().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWisdomAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = new WisdomAttribute();
            //assert
            _attributeSet.Wisdom().Should().Be(expectedAttribute);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnCharismaAttributeScores()
        {
            //arrange
            ICharacterAttribute expectedAttribute = new CharismaAttribute();
            //assert
            _attributeSet.Charisma().Should().Be(expectedAttribute);
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
            _attributeSet.Strength().Set(expectedAttribute.Score());
            //assert
            _attributeSet.Strength().Score().Should().Be(expectedAttribute.Score());
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnTextOfStats()
        {
            //TODO: add all stats
            //assign
            TextOf expectedtTextOf = new TextOf("STR: 11");
            _attributeSet.Strength().Set(new AttributeScore(11));
            //act
            TextOf actualTextOf = _attributeSet.DisplayText();
            //assert
            actualTextOf.Should().Be(expectedtTextOf);
        }

    }
}
