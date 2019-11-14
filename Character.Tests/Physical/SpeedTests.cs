using Character.Physical;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Character.Tests.Physical
{
    [TestClass]
    public class SpeedTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //arrange
            Speed expectedSpeed = new Speed(10);
            Speed actualSpeed = new Speed(10);

            //assert
            actualSpeed.Should().Be(expectedSpeed);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //arrange
            Speed expectedSpeed = new Speed(10);
            Speed actualSpeed = new Speed(12);

            //assert
            actualSpeed.Should().NotBe(expectedSpeed);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldAdd()
        {
            //arrange
            ISpeed expectedSpeed = new Speed(22);
            ISpeed firstSpeed = new Speed(10);
            ISpeed secondSpeed = new Speed(12);

            //act
            ISpeed actualSpeed = firstSpeed.Add(secondSpeed);
            //assert
            actualSpeed.Should().Be(expectedSpeed);
        }
    }
}
