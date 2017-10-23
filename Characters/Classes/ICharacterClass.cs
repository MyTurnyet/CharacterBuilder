using System.Collections.Generic;
using Characters.Attributes;
using Characters.Dice;
using Characters.Display;
using Characters.Physical;
using Characters.Physical.Proficiencies;

namespace Characters.Classes
{
    public interface ICharacterClass
    {
        bool Equals(object obj);
        IHitDie HitDie();
        List<IProficiency> Proficiencies();
        List<ISavingThrowAttribute> SavingThrows();
        List<ISkill> Skills();
        ITextOf Name();
        IHitPoints BaseHitPoints();
    }
}