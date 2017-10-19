using Characters;
using Characters.Physical.Proficiencies;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical
{
    [TestClass]
    public class ProficiencyTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            new Warhammer().Name.Should().Be(new TextOf("Warhammer"));
        }
    }
}
