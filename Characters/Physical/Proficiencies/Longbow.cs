using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Longbow : EquatableProficiency, IProficiency
    {
        public Longbow():base(new TextObj("Longbow"))
        {
            
        }
        public ITextObj Name => ProficiencyName;
    }
}