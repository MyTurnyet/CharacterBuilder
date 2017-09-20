using Characters.Physical;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical
{
    [TestClass]
    public class SizeTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //arrange
            Size size1 = new Size("Tiny", 1);
            Size size2 = new Size("Tiny", 1);

            //assert
            size2.Should().Be(size1);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //arrange
            Size size1 = new Size("Tiny", 1);
            Size size2 = new Size("Small", 3);

            //assert
            size2.Should().NotBe(size1);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldOrderSize()
        {
            //arrange
            Size tiny = new Size("Tiny", 1);
            Size small = new Size("Small", 3);

            //assert
            (tiny < small).Should().BeTrue();
            (small > tiny).Should().BeTrue();
        }
    }
}
