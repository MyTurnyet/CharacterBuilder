namespace Characters.Physical
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class Skill : ISkill
    {
        private readonly TextOf _skillName;
        public static readonly Skill Acrobatics = new Skill(new TextOf("Acrobatics"));
        public static readonly Skill AnimalHandling = new Skill(new TextOf("Animal Handling"));
        public static readonly Skill Arcana = new Skill(new TextOf("Arcana"));
        public static readonly Skill Athletics = new Skill(new TextOf("Athletics"));
        public static readonly Skill Deception = new Skill(new TextOf("Deception"));
        public static readonly Skill History = new Skill(new TextOf("History"));
        public static readonly Skill Insight = new Skill(new TextOf("Insight"));
        public static readonly Skill Intimidation = new Skill(new TextOf("Intimidation"));
        public static readonly Skill Investigation = new Skill(new TextOf("Investigation"));
        public static readonly Skill Medicine = new Skill(new TextOf("Medicine"));
        public static readonly Skill Nature = new Skill(new TextOf("Nature"));
        public static readonly Skill Perception = new Skill(new TextOf("Perception"));
        public static readonly Skill Performance = new Skill(new TextOf("Performance"));
        public static readonly Skill Persuassion= new Skill(new TextOf("Persuassion"));
        public static readonly Skill Religion = new Skill(new TextOf("Religion"));
        public static readonly Skill SlightOfHand = new Skill(new TextOf("Slight Of Hand"));
        public static readonly Skill Stealth = new Skill(new TextOf("Stealth"));
        public static readonly Skill Survival = new Skill(new TextOf("Survival"));

        private Skill(TextOf skillName) => _skillName = skillName;
        public override bool Equals(object obj) => Equals((Skill)obj);
        private bool Equals(Skill other) => string.Equals(_skillName, other._skillName);
    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
