using Characters.Attributes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Attributes
{
    [TestClass]
    public class CharacterAttributeScoreTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //arrange
            ICharacterAttributeScore score1 = new CharacterAttributeScore(4);
            ICharacterAttributeScore score2 = new CharacterAttributeScore(4);

            //assert
            score2.Should().Be(score1);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //arrange
            ICharacterAttributeScore score1 = new CharacterAttributeScore(4);
            ICharacterAttributeScore score2 = new CharacterAttributeScore(8);

            //assert
            score2.Should().NotBe(score1);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldAdd()
        {
            //arrange
            CharacterAttributeScore score1 = new CharacterAttributeScore(4);
            CharacterAttributeScore score2 = new CharacterAttributeScore(8);
            ICharacterAttributeScore totalScore = new CharacterAttributeScore(12);
            //assert
            totalScore.Should().Be(score1 + score2);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldSubtract()
        {
            //arrange
            CharacterAttributeScore score1 = new CharacterAttributeScore(6);
            CharacterAttributeScore score2 = new CharacterAttributeScore(8);
            ICharacterAttributeScore totalScore = new CharacterAttributeScore(2);
            //assert
            totalScore.Should().Be(score2 - score1);
        }
    }
}
