using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Longsword : EquatableProficiency, IProficiency
    {
        public Longsword():base(new TextObj("Longsword"))
        {
            
        }
        public ITextObj Name =>ProficiencyName;
    }
}