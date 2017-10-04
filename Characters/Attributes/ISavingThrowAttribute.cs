namespace Characters.Attributes
{
    public interface ISavingThrowAttribute
    {
        bool Equals(object obj);
        int GetHashCode();
    }
}