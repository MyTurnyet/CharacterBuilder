namespace Characters.Physical.Proficiencies
{
    public class LightCrossbow : EquatableProficiency, IProficiency
    {
        public LightCrossbow():base(new TextOf("LightCrossbow"))
        {
            
        }
        public ITextOf Name => ProficiencyName;
    }
}