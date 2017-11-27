using System.Web.Http;
using System.Web.Http.Results;
using Characters;
using Characters.Attributes;
using Characters.Classes;
using Characters.Races;

namespace CharacterWeb.Controllers
{
    public class CharacterSheetController : ApiController
    {
        [Route("CharacterSheet/Create")]
        [HttpGet]
        public IHttpActionResult CreateSheet(int strength, int dexterity, int constitution, int intellegence, int wisdom, int charisma)
        {
            AttributeSet attributeSet = new AttributeSet();
            attributeSet.SetAttribute(CharacterAttributeName.Strength, new AttributeScore(strength));
            attributeSet.SetAttribute(CharacterAttributeName.Dexterity, new AttributeScore(dexterity));
            attributeSet.SetAttribute(CharacterAttributeName.Constitution, new AttributeScore(constitution));
            attributeSet.SetAttribute(CharacterAttributeName.Intelligence, new AttributeScore(intellegence));
            attributeSet.SetAttribute(CharacterAttributeName.Wisdom, new AttributeScore(wisdom));
            attributeSet.SetAttribute(CharacterAttributeName.Charisma, new AttributeScore(charisma));
            return Ok(new CharacterSheet(new Fighter(), new Human(), attributeSet));
        }
    }
}
