﻿using Characters.Physical;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Physical
{
    [TestClass]
    public class SpeedTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //arrange
            Speed expectedSpeed = new Speed(10);
            Speed actualSpeed = new Speed(10);

            //assert
            actualSpeed.Should().Be(expectedSpeed);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //arrange
            Speed expectedSpeed = new Speed(10);
            Speed actualSpeed = new Speed(12);

            //assert
            actualSpeed.Should().NotBe(expectedSpeed);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldAdd()
        {
            //arrange
            Speed expectedSpeed = new Speed(22);
            Speed firstSpeed = new Speed(10);
            Speed secondSpeed = new Speed(12);

            //act
            Speed actualSpeed = firstSpeed + secondSpeed;
            //assert
            actualSpeed.Should().Be(expectedSpeed);
        }
    }
}
