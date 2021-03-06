﻿using System.Text;
using Character.Classes;
using Character.Display;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Character.Tests.Classes
{
    [TestClass]
    public class CharacterClassTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldEquate()
        {
            //assign
            ICharacterClass classFighter = new Fighter();
            ICharacterClass classFighter2 = new Fighter();

            //assert
            classFighter2.Should().Be(classFighter);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldNotEquate()
        {
            //assign
            ICharacterClass classFighter = new Fighter();
            ICharacterClass classWizard = new Wizard();

            //assert
            classWizard.Should().NotBe(classFighter);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnName()
        {
            //arrange
            ICharacterClass classFighter = new Fighter();
            //act
            ITextObj actualName = classFighter.Name();
            //assert
            actualName.Should().Be(new TextObj("Fighter"));
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnCorrectJson()
        {
            //assign
            string expectedJson = "\"class\":\"Fighter\"";
            StringBuilder stringBuilder = new StringBuilder();
            //act
            new Fighter().AddJsonToStringbuilder(stringBuilder);
            //assert
            stringBuilder.ToString().Should().Be(expectedJson);
        }
    }
}
