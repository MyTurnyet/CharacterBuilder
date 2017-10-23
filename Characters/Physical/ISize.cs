using Characters.Display;

namespace Characters.Physical
{
    public interface ISize
    {
        bool Equals(object obj);
        TextOf Name();
    }
}