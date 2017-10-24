using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Dagger : EquatableProficiency, IProficiency
    {
        public Dagger():base(new TextObj("Dagger"))
        {
            
        }
        public ITextObj Name => ProficiencyName;
    }
}