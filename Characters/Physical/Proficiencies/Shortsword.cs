using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Shortsword : EquatableProficiency, IProficiency
    {
        public Shortsword():base(new TextObj("Shortsword"))
        {
            
        }
        public ITextObj Name => ProficiencyName;
    }
}