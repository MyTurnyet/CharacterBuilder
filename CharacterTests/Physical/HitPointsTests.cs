using Characters.Physical;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical
{
    [TestClass]
    public class HitPointsTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //arrange
            HitPoints hitPoints1 = new HitPoints(6);
            HitPoints hitPoints2 = new HitPoints(6);

            //assert
            hitPoints2.Should().Be(hitPoints1);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldAdd()
        {
            //arrange
            HitPoints score1 = new HitPoints(4);
            HitPoints score2 = new HitPoints(8);
            HitPoints totalScore = new HitPoints(12);
            //assert
            totalScore.Should().Be(score1 + score2);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldSubtract()
        {
            //arrange
            HitPoints score1 = new HitPoints(6);
            HitPoints score2 = new HitPoints(8);
            HitPoints totalScore = new HitPoints(2);
            //assert
            totalScore.Should().Be(score2 - score1);
        }

    }
}
