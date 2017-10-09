using System;
using Characters;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests
{
    [TestClass]
    public class TextOfTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //arrange
            TextOf textOf1 = new TextOf("Test");
            TextOf textOf2 = new TextOf("Test");

            //assert
            textOf2.Should().Be(textOf1);
        }
    }
}
