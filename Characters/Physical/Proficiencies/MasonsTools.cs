namespace Characters.Physical.Proficiencies
{
    public class MasonsTools : EquatableProficiency, IProficiency
    {
        public MasonsTools():base(new TextOf("Mason's Tools"))
        {
            
        }
        public ITextOf Name =>ProficiencyName;
    }
}