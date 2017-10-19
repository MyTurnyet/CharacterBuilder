namespace Characters.Physical.Proficiencies
{
    public interface IProficiency
    {
        bool Equals(object obj);
        ITextOf Name();
    }
}