using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class MasonsTools : EquatableProficiency, IProficiency
    {
        public MasonsTools():base(new TextObj("Mason's Tools"))
        {
            
        }
        public ITextObj Name =>ProficiencyName;
    }
}