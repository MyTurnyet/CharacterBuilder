using Character.Display;

namespace Character.Physical.Proficiencies
{
    public class LightCrossbow : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public LightCrossbow():base(new TextObj("Light Crossbow")){}

        public ITextObj Name() => ProficiencyName;
    }
}