using Characters.Display;

namespace Characters.Physical.Proficiencies
{
    public class AllShields : EquatableProficiency, IProficiency
    {
        public AllShields():base(new TextObj("All Shields"))
        {
            
        }
        public ITextObj Name => ProficiencyName;
    }
}