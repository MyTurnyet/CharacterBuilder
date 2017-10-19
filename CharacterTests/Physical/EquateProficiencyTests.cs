using Characters.Physical.Proficiencies;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical
{
    [TestClass]
    public class EquateProficiencyTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate() => new EquateProficiency(new Handaxe(), new Handaxe()).AreEqual().Should().BeTrue();
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate() => new EquateProficiency(new Handaxe(), new Battleaxe()).AreEqual().Should().BeFalse();

    }
}
