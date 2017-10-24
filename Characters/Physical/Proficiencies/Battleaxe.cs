using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Battleaxe : EquatableProficiency, IProficiency
    {
        public Battleaxe():base(new TextObj("Battleaxe"))
        {
            
        }
        public ITextObj Name => ProficiencyName;
    }
}