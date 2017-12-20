using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class SimpleWeapons : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public SimpleWeapons():base(new TextObj("Simple Weapons")){}

        public ITextObj Name() => ProficiencyName;
    }
}