using System.Collections.Generic;
using Characters.Attributes;
using Characters.Dice;
using Characters.Physical;

namespace Characters.Classes
{
    public interface ICharacterClass
    {
        bool Equals(object obj);
        IHitDie HitDie();
        List<Proficiency> Proficiencies();
        List<SavingThrowAttribute> SavingThrows();
        List<Skill> Skills();
        TextOf Name();
    }
}