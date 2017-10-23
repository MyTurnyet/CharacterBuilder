using Characters.Display;

namespace Characters.Physical
{
    public interface ISkill
    {
        bool Equals(object obj);
        TextOf Name();
    }
}