namespace Characters.Attributes
{
    public interface ICharacterAttributeName
    {
        bool Equals(object obj);
        int GetHashCode();
    }
}