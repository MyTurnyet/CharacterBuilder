using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Quarterstaff : EquatableProficiency, IProficiency
    {
        public Quarterstaff():base(new TextObj("Quarterstaff"))
        {
            
        }
        public ITextObj Name => ProficiencyName;
    }
}