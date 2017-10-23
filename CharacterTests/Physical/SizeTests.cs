using Characters.Display;
using Characters.Physical;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical
{
    [TestClass]
    public class SizeTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate() => Size.Tiny.Should().Be(Size.Tiny);

        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate() => Size.Tiny.Should().NotBe(Size.Medium);

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName() => Size.Medium.Name().Should().Be(new TextOf("Medium"));
    }
}
