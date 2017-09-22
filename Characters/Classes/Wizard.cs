using Characters.Dice;

namespace Characters.Classes
{
    public class Wizard:CharacterClass
    {
        public Wizard() : base("Wizard"){}
        public override HitDie HitDie() => Dice.HitDie.d6;
    }
}
