using System;
using Characters;
using Characters.Classes;
using Characters.Dice;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Classes
{
    [TestClass]
    public class WizardTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldMatchHitDie()
        {
            //arrange
            Wizard wizard = new Wizard();
            Die expecteDie = Die.d6;
            //act
            Die hitDie = wizard.HitDie();
            //assert
            hitDie.Should().Be(expecteDie);
        }

    }
}
