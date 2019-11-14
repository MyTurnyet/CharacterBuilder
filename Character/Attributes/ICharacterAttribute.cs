using System.Text;
using Character.Display;
using Character.Physical;
using Character.Races;

namespace Character.Attributes
{
    public interface ICharacterAttribute
    {
        bool Equals(object obj);
        bool MatchesName(IAttributeName attributeName);
        IAttributeScore Score();
        void ApplyRacialBonus(ICharacterRace race);
        void Set(IAttributeScore expectedScore);
        IAttributeScore Bonus();
        IHitPoints BonusHitPoints();
        //ITextOf DisplayText(ITextOf displayTextOf);
        ITextObj DisplayText();

        void AddJsonToStringbuilder(StringBuilder stringBuilder);
    }
}