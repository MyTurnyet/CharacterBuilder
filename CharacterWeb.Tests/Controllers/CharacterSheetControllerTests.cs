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
            CharacterWebModels actualCharacterModel = CreateSheet();

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
            CharacterWebModels actualCharacterModel = CreateSheet(className: expectedClass);

            //assert
            actualCharacterModel?.CharacterSheet.Race.Should().Be(expectedRace);
            actualCharacterModel?.CharacterSheet.Class.Should().Be(expectedClass);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnHillDwarfFighter()
        {
            //arrange
            const string expectedRace = "Hill Dwarf";
            CharacterWebModels actualCharacterModel = CreateSheet(expectedRace);

            //assert
            actualCharacterModel?.CharacterSheet.Race.Should().Be(expectedRace);
        }

        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnMountainDwarfFighter()
        {
            //arrange
            const string expectedRace = "Mountain Dwarf";
            CharacterWebModels actualCharacterModel = CreateSheet(expectedRace);

            //assert
            actualCharacterModel?.CharacterSheet.Race.Should().Be(expectedRace);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnLightFootFighter()
        {
            //arrange
            const string expectedRace = "Halfling Lightfoot";
            CharacterWebModels actualCharacterModel = CreateSheet(expectedRace);

            //assert
            actualCharacterModel?.CharacterSheet.Race.Should().Be(expectedRace);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnStoutHalflingFighter()
        {
            //arrange
            const string expectedRace = "Stout Halfling";
            CharacterWebModels actualCharacterModel = CreateSheet(expectedRace);

            //assert
            actualCharacterModel?.CharacterSheet.Race.Should().Be(expectedRace);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnHighElfFighter()
        {
            //arrange
            const string expectedRace = "High Elf";
            CharacterWebModels actualCharacterModel = CreateSheet(expectedRace);

            //assert
            actualCharacterModel?.CharacterSheet.Race.Should().Be(expectedRace);
        }
               [TestMethod, TestCategory("Unit")]
        public void ShouldReturnWoodElfFighter()
        {
            //arrange
            const string expectedRace = "Wood Elf";
            CharacterWebModels actualCharacterModel = CreateSheet(expectedRace);

            //assert
            actualCharacterModel?.CharacterSheet.Race.Should().Be(expectedRace);
        }
       
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnCorrectAttributes()
        {
            //arrange
            int expectedValue = 10;
            //act
            CharacterWebModels actualCharacterModel = CreateSheet();

            //assert
            actualCharacterModel?.CharacterSheet.CharacterAttributes.All(att => att.Value == expectedValue).Should().BeTrue();

        }

        private CharacterWebModels CreateSheet(string raceName = "Human", string className = "Fighter")
        {
            CharacterSheetController sheetController = new CharacterSheetController();

            //act
            IHttpActionResult actionResult = sheetController.CreateSheet(raceName, className, 10, 10, 10, 10, 10, 10);
            OkNegotiatedContentResult<CharacterWebModels> result = actionResult as OkNegotiatedContentResult<CharacterWebModels>;
            CharacterWebModels actualCharacterModel = result?.Content;
            actualCharacterModel.Should().NotBeNull();
            return actualCharacterModel;
        }

    }
}
