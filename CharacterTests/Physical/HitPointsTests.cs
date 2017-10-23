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
            IHitPoints hitPoints1 = new HitPoints(4);
            IHitPoints hitPoints = new HitPoints(8);
            IHitPoints totalScore = new HitPoints(12);
            IHitPoints actualHitPoints = hitPoints1.Add(hitPoints);
            //assert
            totalScore.Should().Be(actualHitPoints);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldSubtract()
        {
            //arrange
            IHitPoints hitPoints1 = new HitPoints(6);
            IHitPoints hitPoints2 = new HitPoints(8);
            IHitPoints totalScore = new HitPoints(2);
            IHitPoints actualHitPoints = hitPoints2.Subtract(hitPoints1);
            //assert
            actualHitPoints.Should().Be(totalScore);
        }

    }
}
