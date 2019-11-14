using Character.Display;

namespace Character.Attributes
{
    public interface IAttributeName
    {
        bool Equals(object obj);
        TextObj Name();
    }
}