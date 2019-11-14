using System.Collections.Generic;
using System.Text;
using Character.Attributes;
using Character.Display;
using Character.Physical;
using Character.Physical.Proficiencies;
using Character.Physical.Skills;

namespace Character
{
    public interface ICharacterSheet
    {
        ICharacterAttribute Attribute(IAttributeName attributeName);
        IHitPoints HitPoints();
        List<IProficiency> Proficiencies();
        ITextObj StatsList();
        List<ISkill> Skills();
        void ActivateSkill(ISkill skill);
        void AddJsonToStringbuilder(StringBuilder stringBuilder);
    }
}