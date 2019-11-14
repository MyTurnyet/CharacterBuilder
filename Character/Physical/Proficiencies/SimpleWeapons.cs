using Character.Display;

namespace Character.Physical.Proficiencies
{
    public class SimpleWeapons : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public SimpleWeapons():base(new TextObj("Simple Weapons")){}

        public ITextObj Name() => ProficiencyName;
    }
}