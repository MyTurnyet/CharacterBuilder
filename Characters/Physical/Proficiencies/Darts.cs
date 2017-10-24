using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Darts : EquatableProficiency, IProficiency
    {
        public Darts():base(new TextObj("Darts"))
        {
            
        }
        public ITextObj Name =>ProficiencyName;
    }
}