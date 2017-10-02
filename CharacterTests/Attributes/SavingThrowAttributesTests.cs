using System;
using Characters.Attributes;
using Characters.Physical;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Attributes
{
    [TestClass]
    public class SavingThrowAttributesTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate() => SavingThrowAttribute.Strength.Should().Be(SavingThrowAttribute.Strength);
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate() => SavingThrowAttribute.Strength.Should().NotBe(SavingThrowAttribute.Dexterity);
    }
}
