using Character.Display;

namespace Character.Physical.Proficiencies
{
    public class MartialWeapons : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public MartialWeapons():base(new TextObj("Martial Weapons")){}

        public ITextObj Name() => ProficiencyName;
    }
}