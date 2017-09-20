namespace Characters.Attributes
{
    public interface IAttributeScore
    {
        bool Equals(object obj);
        int GetHashCode();
    }
}