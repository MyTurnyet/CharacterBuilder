using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class MartialWeapons : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public MartialWeapons():base(new TextObj("Martial Weapons")){}

        public ITextObj Name() => ProficiencyName;
    }
}