using System.Collections.Generic;
using Characters.Dice;
using Characters.Physical;

namespace Characters.Classes
{
    public interface ICharacterClass
    {
        bool Equals(object obj);
        int GetHashCode();
        HitDie HitDie();
        List<Proficiency> Proficiencies();
    }
}