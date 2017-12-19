using System.Linq;
using System.Web.Http;
using System.Web.Http.Results;
using CharacterWeb.Controllers;
using CharacterWeb.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterWeb.Tests.Controllers
{
    [TestClass]
    public class CharacterSheetControllerTests
    {
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnHumanFighter()
        {
            //arrange
            const string expectedRace = "Human";
            const string expectedClass = "Fighter";
            CharacterWebModels actualCharacterModel = CreateSheet(expectedRace, expectedClass);

            //assert
            actualCharacterModel?.CharacterSheet.Race.Should().Be(expectedRace);
            actualCharacterModel?.CharacterSheet.Class.Should().Be(expectedClass);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnHumanWizard()
        {
            //arrange
            const string expectedRace = "Human";
            const string expectedClass = "Wizard";
            CharacterWebModels actualCharacterModel = CreateSheet(expectedRace, expectedClass);

            //assert
            actualCharacterModel?.CharacterSheet.Race.Should().Be(expectedRace);
            actualCharacterModel?.CharacterSheet.Class.Should().Be(expectedClass);
        }


        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnHillDwarfWizard()
        {
            //arrange
            const string expectedRace = "Hill Dwarf";
            const string expectedClass = "Wizard";
            CharacterWebModels actualCharacterModel = CreateSheet(expectedRace, expectedClass);

            //assert
            actualCharacterModel?.CharacterSheet.Race.Should().Be(expectedRace);
            actualCharacterModel?.CharacterSheet.Class.Should().Be(expectedClass);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnCorrectAttributes()
        {
            //arrange
            const string expectedRace = "Human";
            const string expectedClass = "Fighter";
            int expectedValue = 10;
            //act
            CharacterWebModels actualCharacterModel = CreateSheet(expectedRace, expectedClass);

            //assert
            actualCharacterModel?.CharacterSheet.CharacterAttributes.All(att => att.Value == expectedValue).Should().BeTrue();

        }
        private CharacterWebModels CreateSheet(string expectedRace, string expectedClass)
        {
            CharacterSheetController sheetController = new CharacterSheetController();

            //act
            IHttpActionResult actionResult = sheetController.CreateSheet(expectedRace, expectedClass, 10, 10, 10, 10, 10, 10);
            OkNegotiatedContentResult<CharacterWebModels> result = actionResult as OkNegotiatedContentResult<CharacterWebModels>;
            CharacterWebModels actualCharacterModel = result?.Content;
            actualCharacterModel.Should().NotBeNull();
            return actualCharacterModel;
        }

    }
}
