using Characters.Display;

namespace Characters.Physical.Skills
{
    public interface ISkill
    {
        bool Equals(object obj);
        TextOf Name();
    }
}