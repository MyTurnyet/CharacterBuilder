using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Quarterstaff : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public Quarterstaff():base(new TextObj("Quarterstaff")){}

        public ITextObj Name() => ProficiencyName;
    }
}