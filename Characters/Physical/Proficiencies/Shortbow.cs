namespace Characters.Physical.Proficiencies
{
    public class Shortbow : EquatableProficiency, IProficiency
    {
        public Shortbow():base(new TextOf("Shortbow"))
        {
            
        }
        public ITextOf Name => ProficiencyName;
    }
}