namespace Characters.Physical.Proficiencies
{
    public class Sling : EquatableProficiency, IProficiency
    {
        public Sling():base(new TextOf("Sling"))
        {
            
        }
        public ITextOf Name => ProficiencyName;
    }
}