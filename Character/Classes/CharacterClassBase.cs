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
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public abstract class CharacterClassBase
    {
        private readonly ITextObj _className;
      protected CharacterClassBase(ITextObj className)
        {
            _className = className;
        }
        public override bool Equals(object obj) => (CharacterClassBase)obj != null && Equals((CharacterClassBase)obj);
        private bool Equals(CharacterClassBase other) => Equals(_className, other._className);
        public abstract IHitDie HitDie();
        public abstract List<IProficiency> Proficiencies();
        public abstract List<ISavingThrowAttribute> SavingThrows();
        public abstract List<ISkill> Skills();
        public ITextObj Name() => _className;
        public IHitPoints BaseHitPoints() => HitDie().MaxHitPoints();
        public void AddJsonToStringbuilder(StringBuilder stringbuilder)
        {
            stringbuilder.Append("\"class\":\"");
            _className.AddToStringBuilder(stringbuilder);
            stringbuilder.Append("\"");
        }

    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
