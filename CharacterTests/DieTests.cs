using System;
using Characters;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests
{
    [TestClass]
    public class DieTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //arrange
            Die die1 = new Die(6);
            Die die2 = new Die(6);

            //assert
            die1.Should().Be(die2);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //arrange
            Die die1 = new Die(2);
            Die die2 = new Die(6);

            //assert
            die1.Should().NotBe(die2);
        }
    }
}
