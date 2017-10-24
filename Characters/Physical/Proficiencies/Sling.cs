using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Sling : EquatableProficiency, IProficiency
    {
        public Sling():base(new TextObj("Sling"))
        {
            
        }
        public ITextObj Name => ProficiencyName;
    }
}