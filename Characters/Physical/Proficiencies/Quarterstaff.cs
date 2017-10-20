namespace Characters.Physical.Proficiencies
{
    public class Quarterstaff : EquatableProficiency, IProficiency
    {
        public Quarterstaff():base(new TextOf("Quarterstaff"))
        {
            
        }
        public ITextOf Name => ProficiencyName;
    }
}