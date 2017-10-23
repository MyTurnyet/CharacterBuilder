namespace Characters.Physical
{
    public interface ISpeed
    {
        bool Equals(object obj);
        ISpeed Add(ISpeed speedToAdd);
    }
}