using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class MartialWeapons : EquatableProficiency, IProficiency
    {
        public MartialWeapons():base(new TextOf("Martial Weapons"))
        {
            
        }
        public ITextOf Name =>ProficiencyName;
    }
}