namespace Characters.Dice
{
    public interface IDie
    {
        bool Equals(object obj);
        int GetHashCode();
    }
}