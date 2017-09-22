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
            Die die1 = Die.d6;
            Die die2 = Die.d6;

            //assert
            die1.Should().Be(die2);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //arrange
            Die die1 = Die.d6;
            Die die2 = Die.d10;

            //assert
            die1.Should().NotBe(die2);
        }
    }
}
