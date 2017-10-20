namespace Characters.Physical.Proficiencies
{
    public class Dagger : EquatableProficiency, IProficiency
    {
        public Dagger():base(new TextOf("Dagger"))
        {
            
        }
        public ITextOf Name => ProficiencyName;
    }
}