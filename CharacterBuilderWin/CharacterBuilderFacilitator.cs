using System.Text;
using Characters;
using Characters.Display;

namespace CharacterBuilderWin
{
    public class CharacterBuilderFacilitator : ICharacterBuilderFacilitator
    {
        private readonly ICharacterSheet _characterSheet;

        public CharacterBuilderFacilitator(ICharacterSheet characterSheet)
        {
            _characterSheet = characterSheet;
        }

        public CharacterBuilderFacilitator():this(new CharacterSheet()){}

        public StringBuilder CharacterSheetText()
        {
            ITextOf stats =  _characterSheet.StatsList();
            StringBuilder stringBuilder = new StringBuilder();
            stats.AddToStringBuilder(stringBuilder);
            return stringBuilder;
        }
    }
}
