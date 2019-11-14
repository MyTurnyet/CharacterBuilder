using Character.Display;

namespace Character.Physical.Sizes
{
    public interface ISize
    {
        bool Equals(object obj);
        TextObj Name();
    }
}