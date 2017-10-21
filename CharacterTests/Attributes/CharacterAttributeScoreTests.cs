using Characters;
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
            IAttributeScore score1 = new AttributeScore(4);
            IAttributeScore score2 = new AttributeScore(4);

            //assert
            score2.Should().Be(score1);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //arrange
            IAttributeScore score1 = new AttributeScore(4);
            IAttributeScore score2 = new AttributeScore(8);

            //assert
            score2.Should().NotBe(score1);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldAdd()
        {
            //arrange
            AttributeScore score1 = new AttributeScore(4);
            AttributeScore score2 = new AttributeScore(8);
            IAttributeScore totalScore = new AttributeScore(12);
            //assert
            totalScore.Should().Be(score1 + score2);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldSubtract()
        {
            //arrange
            AttributeScore score1 = new AttributeScore(6);
            AttributeScore score2 = new AttributeScore(8);
            IAttributeScore totalScore = new AttributeScore(2);
            //assert
            totalScore.Should().Be(score2 - score1);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnAsText()
        {
            //arrange
            AttributeScore score1 = new AttributeScore(6);
            //assert
            score1.AsText().Should().Be(new TextOf("6"));
        }
    }
}
