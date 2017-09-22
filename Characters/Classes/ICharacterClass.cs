using Characters.Dice;

namespace Characters.Classes
{
    public interface ICharacterClass
    {
        bool Equals(object obj);
        int GetHashCode();
        HitDie HitDie();
    }
}