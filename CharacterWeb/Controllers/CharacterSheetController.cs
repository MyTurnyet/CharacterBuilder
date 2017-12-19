using System.Text;
using System.Web.Http;
using Characters.Attributes;
using Characters.Classes;
using Characters.Races;
using CharacterWeb.Models;
using CharacterSheet = Characters.CharacterSheet;

namespace CharacterWeb.Controllers
{
    public class CharacterSheetController : ApiController
    {
        [Route("api/CharacterSheet/Create/{race}/{className}")]
        [HttpGet]
        public IHttpActionResult CreateSheet(string race, string className, int strength, int dexterity, int constitution, int intellegence, int wisdom, int charisma)
        {
            AttributeSet attributeSet = new AttributeSet();
            attributeSet.SetAttribute(CharacterAttributeName.Strength, new AttributeScore(strength));
            attributeSet.SetAttribute(CharacterAttributeName.Dexterity, new AttributeScore(dexterity));
            attributeSet.SetAttribute(CharacterAttributeName.Constitution, new AttributeScore(constitution));
            attributeSet.SetAttribute(CharacterAttributeName.Intelligence, new AttributeScore(intellegence));
            attributeSet.SetAttribute(CharacterAttributeName.Wisdom, new AttributeScore(wisdom));
            attributeSet.SetAttribute(CharacterAttributeName.Charisma, new AttributeScore(charisma));
            CharacterSheet characterSheet = new CharacterSheet(new Fighter(), new Human(), attributeSet);
            StringBuilder stringBuilder = new StringBuilder();
            characterSheet.AddJsonToStringbuilder(stringBuilder);
            CharacterWebModels characterWebModels = CharacterWebModels.FromJson(stringBuilder.ToString());
            return Ok(characterWebModels);
        }
    }
}
