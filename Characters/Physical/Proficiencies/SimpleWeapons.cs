using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class SimpleWeapons : EquatableProficiency, IProficiency
    {
        public SimpleWeapons():base(new TextObj("Simple Weapons"))
        {
            
        }
        public ITextObj Name => ProficiencyName;
    }
}