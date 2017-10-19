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

        public IHitPoints HitPoints()
        {
            throw new System.NotImplementedException();
        }

        public List<IProficiency> Proficiencies()
        {
            throw new System.NotImplementedException();
        }

        public ITextOf StatsList()
        {
            return new TextOf("Strength: 10");
        }
    }
}