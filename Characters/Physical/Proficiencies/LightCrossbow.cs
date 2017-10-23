using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class LightCrossbow : EquatableProficiency, IProficiency
    {
        public LightCrossbow():base(new TextOf("Light Crossbow"))
        {
            
        }
        public ITextOf Name => ProficiencyName;
    }
}