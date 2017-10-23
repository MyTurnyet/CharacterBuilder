using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Handaxe : EquatableProficiency, IProficiency
    {
        public Handaxe():base(new TextOf("Handaxe"))
        {
            
        }
        public ITextOf Name => ProficiencyName;
    }
}