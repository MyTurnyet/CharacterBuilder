namespace Characters.Attributes
{
    public interface IAttributeName
    {
        bool Equals(object obj);
        int GetHashCode();
    }
}