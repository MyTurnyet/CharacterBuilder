using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class AllShields : EquatableProficiency, IProficiency
    {
        public AllShields():base(new TextOf("All Shields"))
        {
            
        }
        public ITextOf Name => ProficiencyName;
    }
}