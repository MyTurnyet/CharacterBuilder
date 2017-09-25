﻿using System;
using Characters;
using Characters.Classes;
using Characters.Dice;
using Characters.Physical;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTests.Classes
{
    [TestClass]
    public class FighterTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldMatchHitDie()
        {
            //arrange
            Fighter fighter = new Fighter();
            Die expecteDie = Die.d10;
            //act
            Die hitDie = fighter.HitDie();
            //assert
            hitDie.Should().Be(expecteDie);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnHitPointsFromHitDie()
        {
            //arrange
            Fighter fighter = new Fighter();
            HitPoints expectedHitPoints = new HitPoints(10);

            //act
            HitPoints actualHitPoints = fighter.BaseHitPoints();
            //assert
            actualHitPoints.Should().Be(expectedHitPoints);
        }
    }
}