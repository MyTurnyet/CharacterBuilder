using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class ThrowingHammer : EquatableProficiency, IProficiency
    {
        public ThrowingHammer():base(new TextOf("Throwing Hammer"))
        {
            
        }
        public ITextOf Name => ProficiencyName;
    }
}