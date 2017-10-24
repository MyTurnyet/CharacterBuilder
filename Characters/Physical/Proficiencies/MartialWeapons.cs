using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class MartialWeapons : EquatableProficiency, IProficiency
    {
        public MartialWeapons():base(new TextObj("Martial Weapons"))
        {
            
        }
        public ITextObj Name =>ProficiencyName;
    }
}