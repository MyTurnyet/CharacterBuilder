using Character.Display;

namespace Character.Physical.Proficiencies
{
    public class Quarterstaff : ProficiencyBase, IProficiency, IEquateableProficiency
    {
        public Quarterstaff():base(new TextObj("Quarterstaff")){}

        public ITextObj Name() => ProficiencyName;
    }
}