using System.Collections.Generic;
using System.Text;
using Character.Attributes;
using Character.Display;
using Character.Physical;
using Character.Physical.Proficiencies;
using Character.Physical.Sizes;

namespace Character.Races
{
    public interface ICharacterRace
    {
        bool Equals(object obj);
        int GetHashCode();
        IAttributeScore RacialAttributeAdjustment(ICharacterAttribute attribute);
        ISpeed Speed();
        IHitPoints BonusHitPoints();
        List<IProficiency> Proficiencies();
        ITextObj Name();
        ISize Size();
        void AddJsonToStringbuilder(StringBuilder stringBuilder);
    }
}