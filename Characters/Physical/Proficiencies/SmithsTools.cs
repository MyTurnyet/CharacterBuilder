using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class SmithsTools : EquatableProficiency, IProficiency
    {
        public SmithsTools():base(new TextOf("Smith's Tools"))
        {
            
        }
        public ITextOf Name => ProficiencyName;
    }
}