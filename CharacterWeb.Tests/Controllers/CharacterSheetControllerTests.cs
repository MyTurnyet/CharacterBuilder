using System.Web.Http;
using System.Web.Http.Results;
using CharacterWeb.Controllers;
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
            CharacterSheetController sheetController = new CharacterSheetController();
            IHttpActionResult actionResult = sheetController.CreateSheet(10, 10, 10, 10, 10, 10);
            OkNegotiatedContentResult<string> result = actionResult as OkNegotiatedContentResult<string>;
            string raceJson = "\"race\":\"Human\"";
            string classFighter = "\"class\":\"Fighter\"";
            string attributeSetJson = "\"characterAttributes\":[" +
                                      "{\"characterAttribute\":\"STR\",\"value\":10}" +
                                      "{\"characterAttribute\":\"DEX\",\"value\":10}" +
                                      "{\"characterAttribute\":\"CON\",\"value\":10}" +
                                      "{\"characterAttribute\":\"INT\",\"value\":10}" +
                                      "{\"characterAttribute\":\"WIS\",\"value\":10}" +
                                      "{\"characterAttribute\":\"CHR\",\"value\":10}" +
                                      "]";
       
            string expectedJson = "{characterSheet:{" +
                                  $"{raceJson}," +
                                  $"{classFighter}," +
                                  $"{attributeSetJson}" +
                                  "}}";
            //assert
            result.Should().NotBeNull();
            result?.Content.Should().Be(expectedJson);
        }
    }
}
