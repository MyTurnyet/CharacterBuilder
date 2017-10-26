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
            DieBase die1 = new D4Die();
            DieBase die2 = new D4Die();

            //assert
            die1.Should().Be(die2);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //arrange
            DieBase die1 = new D4Die();
            DieBase die2 = new D6Die();

            //assert
            die1.Should().NotBe(die2);
        }
    }
}
