using Character.Display;
using Character.Physical.Sizes;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Character.Tests.Physical
{
    [TestClass]
    public class SizeTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate() => new Medium().Should().Be(new Medium());

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnMediumName() => new Medium().Name().Should().Be(new TextObj("Medium"));
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnSmallName() => new Small().Name().Should().Be(new TextObj("Small"));
    }
}
