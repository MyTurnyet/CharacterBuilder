using Character.Attributes;
using Character.Display;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Character.Tests.Attributes
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
            IAttributeScore actualScore = score1.Add(score2);
            //assert
            totalScore.Should().Be(actualScore);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldSubtract()
        {
            //arrange
            AttributeScore score1 = new AttributeScore(6);
            AttributeScore score2 = new AttributeScore(8);
            IAttributeScore totalScore = new AttributeScore(2);
            IAttributeScore actualScore = score2.Subtract(score1);
            //assert
            totalScore.Should().Be(actualScore);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnAsText()
        {
            //arrange
            AttributeScore score1 = new AttributeScore(6);
            //assert
            score1.AsText().Should().Be(new TextObj("6"));
        }
    }
}
