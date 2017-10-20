namespace Characters.Physical.Proficiencies
{
    public class SimpleWeapons : EquatableProficiency, IProficiency
    {
        public SimpleWeapons():base(new TextOf("Simple Weapons"))
        {
            
        }
        public ITextOf Name => ProficiencyName;
    }
}