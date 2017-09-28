using System;
using Characters.Physical;
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
    }
}
