using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using Characters;
using CharacterWeb.Controllers;
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

            //assert
            //Task<HttpResponseMessage> executeAsync = actionResult.ExecuteAsync(new CancellationToken());
            //executeAsync.Wait();
        }
    }
}
