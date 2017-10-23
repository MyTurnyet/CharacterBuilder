using Characters.Display;

namespace Characters.Attributes
{
    public interface IAttributeName
    {
        bool Equals(object obj);
        TextOf Name();
    }
}