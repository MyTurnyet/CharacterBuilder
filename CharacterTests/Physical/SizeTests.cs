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
        public void ShouldOrderSize()
        {
            //assert
            (Size.Tiny < Size.Small).Should().BeTrue();
            (Size.Small < Size.Medium).Should().BeTrue();
            (Size.Medium < Size.Large).Should().BeTrue();
            (Size.Large < Size.Huge).Should().BeTrue();
            (Size.Huge < Size.Gargantuan).Should().BeTrue();
            (Size.Gargantuan > Size.Huge).Should().BeTrue();
            (Size.Huge > Size.Large).Should().BeTrue();
            (Size.Large > Size.Medium).Should().BeTrue();
            (Size.Medium > Size.Small).Should().BeTrue();
            (Size.Small > Size.Tiny).Should().BeTrue();
        }
    }
}
