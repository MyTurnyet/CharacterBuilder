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
            ICharacterClass selectedClass = CharacterClass(className);
            ICharacterRace selectedRace = Race(race);
            AttributeSet attributeSet = new AttributeSet(new AttributeScore(strength), new AttributeScore(dexterity), new AttributeScore(constitution),
                new AttributeScore(intellegence), new AttributeScore(wisdom), new AttributeScore(charisma));
            CharacterSheet characterSheet = new CharacterSheet(selectedClass, selectedRace, attributeSet);
            StringBuilder stringBuilder = new StringBuilder();
            characterSheet.AddJsonToStringbuilder(stringBuilder);
            CharacterWebModels characterWebModels = new DeserializeWebModel(stringBuilder.ToString()).CharacterModels();
            return Ok(characterWebModels);
        }

        private ICharacterRace Race(string race)
        {
            ICharacterRace actualRace = CheckDwarf(race, new Human());
            actualRace = CheckHalfling(race, actualRace);
            actualRace = CheckElf(race, actualRace);
            return actualRace;
        }

        private ICharacterRace CheckElf(string race, ICharacterRace actualRace)
        {
            if (!race.Contains("Elf")) return actualRace;
            if (race == "High Elf") return new HighElf();
            return new WoodElf();
        }
        private ICharacterRace CheckDwarf(string race, ICharacterRace actualRace)
        {
            if (!race.Contains("Dwarf")) return actualRace;
            if (race == "Hill Dwarf") return new HillDwarf();
            return new MountainDwarf();
        }
        private ICharacterRace CheckHalfling(string race, ICharacterRace actualRace)
        {
            if (!race.Contains("Halfling")) return actualRace;
            if (race == "Halfling Lightfoot") return new HalflingLightfoot();
            return new HalflingStout();
        }

        private ICharacterClass CharacterClass(string className)
        {
            if (className == "Wizard") return new Wizard();
            return new Fighter();
        }
    }
}
