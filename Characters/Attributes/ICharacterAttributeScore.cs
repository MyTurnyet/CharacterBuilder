namespace Characters.Attributes
{
    public interface ICharacterAttributeScore
    {
        bool Equals(object obj);
        int GetHashCode();
    }
}