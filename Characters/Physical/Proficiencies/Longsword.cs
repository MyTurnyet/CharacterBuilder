namespace Characters.Physical.Proficiencies
{
    public class Longsword : EquatableProficiency, IProficiency
    {
        public Longsword():base(new TextOf("Longsword"))
        {
            
        }
        public ITextOf Name =>ProficiencyName;
    }
}