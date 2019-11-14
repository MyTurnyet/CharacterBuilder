using System.Collections.Generic;
using System.Text;
using Character.Attributes;
using Character.Dice;
using Character.Display;
using Character.Physical;
using Character.Physical.Proficiencies;
using Character.Physical.Skills;

namespace Character.Classes
{
    public interface ICharacterClass
    {
        bool Equals(object obj);
        IHitDie HitDie();
        List<IProficiency> Proficiencies();
        List<ISavingThrowAttribute> SavingThrows();
        List<ISkill> Skills();
        ITextObj Name();
        IHitPoints BaseHitPoints();
        void AddJsonToStringbuilder(StringBuilder stringbuilder);
    }
}