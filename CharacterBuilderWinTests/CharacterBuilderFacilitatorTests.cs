using System;
using CharacterBuilderWin;
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
            ICharacterSheet fakeHumanFighterCharacterSheet = new FakeCharacterSheet(10,10,10,10,10,10);
            CharacterBuilderFacilitator characterBuilderFacilitator = new CharacterBuilderFacilitator(fakeHumanFighterCharacterSheet);

            //act
            ICharacterSheet actualSheet = characterBuilderFacilitator.CharacterSheet();
            //assert
            actualSheet.Should().Be(fakeHumanFighterCharacterSheet);
        }

    }
}
