namespace Characters.Physical.Proficiencies
{
    public class Darts : EquatableProficiency, IProficiency
    {
        public Darts():base(new TextOf("Darts"))
        {
            
        }
        public ITextOf Name =>ProficiencyName;
    }
}