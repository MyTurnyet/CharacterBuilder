using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class LightCrossbow : EquatableProficiency, IProficiency
    {
        public LightCrossbow():base(new TextObj("Light Crossbow"))
        {
            
        }
        public ITextObj Name => ProficiencyName;
    }
}