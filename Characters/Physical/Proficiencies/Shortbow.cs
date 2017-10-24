using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Shortbow : EquatableProficiency, IProficiency
    {
        public Shortbow():base(new TextObj("Shortbow"))
        {
            
        }
        public ITextObj Name => ProficiencyName;
    }
}