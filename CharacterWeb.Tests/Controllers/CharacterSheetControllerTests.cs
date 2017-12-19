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
            CharacterSheetController sheetController = new CharacterSheetController();

            //act
            IHttpActionResult actionResult = sheetController.CreateSheet(expectedRace, expectedClass, 10, 10, 10, 10, 10, 10);
            OkNegotiatedContentResult<CharacterWebModels> result = actionResult as OkNegotiatedContentResult<CharacterWebModels>;
            CharacterWebModels actualCharacterModel = result?.Content;

            //assert
            actualCharacterModel?.CharacterSheet.Race.Should().Be(expectedRace);
            actualCharacterModel?.CharacterSheet.Class.Should().Be(expectedClass);
        }
        [TestMethod, TestCategory("Unit")]
        public void ShouldReturnCorrectAttributes()
        {
            //arrange
            CharacterSheetController sheetController = new CharacterSheetController();
            const string expectedRace = "Human";
            const string expectedClass = "Fighter";
            int expectedValue = 10;
            //act
            IHttpActionResult actionResult = sheetController.CreateSheet(expectedRace, expectedClass, expectedValue, expectedValue, expectedValue, expectedValue, expectedValue, expectedValue);
            OkNegotiatedContentResult<CharacterWebModels> result = actionResult as OkNegotiatedContentResult<CharacterWebModels>;
            CharacterWebModels actualCharacterModel = result?.Content;

            //assert
            actualCharacterModel?.CharacterSheet.CharacterAttributes.All(att => att.Value == expectedValue).Should().BeTrue();

        }
    }
}
