using Characters.Display;

namespace Characters.Physical.Sizes
{
    public interface ISize
    {
        bool Equals(object obj);
        TextOf Name();
    }
}