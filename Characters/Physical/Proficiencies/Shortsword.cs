using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Shortsword : EquatableProficiency, IProficiency
    {
        public Shortsword():base(new TextOf("Shortsword"))
        {
            
        }
        public ITextOf Name => ProficiencyName;
    }
}