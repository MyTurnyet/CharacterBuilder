using Characters;
using Characters.Physical;
using Characters.Physical.Proficiencies;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical
{
    [TestClass]
    public class ProficiencyTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            Proficiency.Battleaxe.Should().Be(Proficiency.Battleaxe);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            Proficiency.Battleaxe.Should().NotBe(Proficiency.Warhammer);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //arrange
            ITextOf expectedName = new TextOf("Warhammer");
            //act
            ITextOf actualName = Proficiency.Warhammer.Name();
            //assert
            actualName.Should().Be(expectedName);
        }
    }
}
