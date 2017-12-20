﻿using System.Text;
using System.Web.Http;
using Characters.Attributes;
using Characters.Classes;
using Characters.Races;
using CharacterWeb.Models;
using WebGrease.Css.Ast.Selectors;
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
            AttributeSet attributeSet = new AttributeSet(strength, dexterity,constitution,intellegence,wisdom,charisma);
            CharacterSheet characterSheet = new CharacterSheet(selectedClass, selectedRace, attributeSet);
            StringBuilder stringBuilder = new StringBuilder();
            characterSheet.AddJsonToStringbuilder(stringBuilder);
            CharacterWebModels characterWebModels = CharacterWebModels.FromJson(stringBuilder.ToString());
            return Ok(characterWebModels);
        }

        private ICharacterRace Race(string race)
        {
            if (race == "Hill Dwarf") return new HillDwarf();
            return new Human();
        }

        private ICharacterClass CharacterClass(string className)
        {
            if (className == "Wizard") return new Wizard();
            return new Fighter();
        }
    }
}
