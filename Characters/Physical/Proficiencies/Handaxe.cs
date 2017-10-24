using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Handaxe : EquatableProficiency, IProficiency
    {
        public Handaxe():base(new TextObj("Handaxe"))
        {
            
        }
        public ITextObj Name => ProficiencyName;
    }
}