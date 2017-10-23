using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class Battleaxe : EquatableProficiency, IProficiency
    {
        public Battleaxe():base(new TextOf("Battleaxe"))
        {
            
        }
        public ITextOf Name => ProficiencyName;
    }
}