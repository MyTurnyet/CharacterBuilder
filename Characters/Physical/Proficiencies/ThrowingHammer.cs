using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class ThrowingHammer : EquatableProficiency, IProficiency
    {
        public ThrowingHammer():base(new TextObj("Throwing Hammer"))
        {
            
        }
        public ITextObj Name => ProficiencyName;
    }
}