using System.Collections.Generic;
using Characters;
using Characters.Attributes;
using Characters.Physical;

namespace CharacterBuilderWinTests.Fakes
{
    internal class FakeCharacterSheet:ICharacterSheet
    {
        public FakeCharacterSheet():this(10,10,10,10,10,10){}

        public FakeCharacterSheet(int strength, int dexterity, int constitution, int intellegence, int wisdom, int charisma)
        {
            
        }

        public ICharacterAttribute Attribute(IAttributeName attributeName)
        {
            throw new System.NotImplementedException();
        }

        public HitPoints HitPoints()
        {
            throw new System.NotImplementedException();
        }

        public List<Proficiency> Proficiencies()
        {
            throw new System.NotImplementedException();
        }

        public TextOf StatsList()
        {
            throw new System.NotImplementedException();
        }
    }
}