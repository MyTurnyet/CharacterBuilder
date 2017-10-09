using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters;

namespace CharacterBuilderWin
{
    public class CharacterBuilderFacilitator
    {
        private readonly ICharacterSheet _characterSheet;

        public CharacterBuilderFacilitator(ICharacterSheet characterSheet)
        {
            _characterSheet = characterSheet;
        }

        public CharacterBuilderFacilitator():this(new CharacterSheet()){}

        public ICharacterSheet CharacterSheet() => _characterSheet;
    }
}
