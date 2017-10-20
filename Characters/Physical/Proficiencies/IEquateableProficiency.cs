namespace Characters.Physical.Proficiencies
{
    public interface IEquateableProficiency
    {
        bool Equals(object obj);
        int GetHashCode();
    }
}