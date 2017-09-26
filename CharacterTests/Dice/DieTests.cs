using Characters.Dice;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Dice
{
    [TestClass]
    public class DieTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //arrange
            Die die1 = Die.d4;
            Die die2 = Die.d4;

            //assert
            die1.Should().Be(die2);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //arrange
            Die die1 = Die.d4;
            Die die2 = Die.d6;

            //assert
            die1.Should().NotBe(die2);
        }
    }
}
