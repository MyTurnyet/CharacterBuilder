using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Longbow : EquatableProficiency, IProficiency
    {
        public Longbow():base(new TextOf("Longbow"))
        {
            
        }
        public ITextOf Name => ProficiencyName;
    }
}