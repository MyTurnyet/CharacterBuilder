using Characters.Dice;
using Characters.Physical;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Dice
{
    [TestClass]
    public class HitDieTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnMaximumHitpoints()
        {
            //arrange
            HitPoints expectedHitPoints = new HitPoints(10);
            //act
            HitPoints actualHitPoints = HitDie.Fighter.MaxHitPoints();

            //assert
            actualHitPoints.Should().Be(expectedHitPoints);
        }
    }
}
