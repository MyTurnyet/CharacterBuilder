using Character.Dice;
using Character.Physical;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Character.Tests.Dice
{
    [TestClass]
    public class HitDieTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnMaximumHitpoints()
        {
            //arrange
            IHitPoints expectedHitPoints = new HitPoints(10);
            //act
            IHitPoints actualHitPoints = new FighterHitDie().MaxHitPoints();
            //assert
            actualHitPoints.Should().Be(expectedHitPoints);
        }
    }
}
