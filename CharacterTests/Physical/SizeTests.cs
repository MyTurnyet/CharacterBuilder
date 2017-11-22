using Characters.Display;
using Characters.Physical.Sizes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical
{
    [TestClass]
    public class SizeTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate() => new Medium().Should().Be(new Medium());

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName() => new Medium().Name().Should().Be(new TextObj("Medium"));
    }
}
