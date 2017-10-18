using System;
using System.Text;
using CharacterBuilderWin;
using CharacterBuilderWinTests.Fakes;
using Characters;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterBuilderWinTests
{
    [TestClass]
    public class CharacterBuilderFacilitatorTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnCharacterSheet()
        {
            //arrange
            ICharacterSheet fakeHumanFighterCharacterSheet = new FakeCharacterSheet(10, 10, 10, 10, 10, 10);
            CharacterBuilderFacilitator characterBuilderFacilitator = new CharacterBuilderFacilitator(fakeHumanFighterCharacterSheet);
            StringBuilder sb = new StringBuilder("Strength: 10");
            //act
            StringBuilder actualSheet = characterBuilderFacilitator.CharacterSheetText();
            //assert
            actualSheet.ToString().Should().Be(sb.ToString());
        }

    }

   
}
