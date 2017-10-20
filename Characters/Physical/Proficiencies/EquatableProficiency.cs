namespace Characters.Physical.Proficiencies
{
    public abstract class EquatableProficiency : IEquateableProficiency
    {
        protected readonly ITextOf ProficiencyName;

        protected EquatableProficiency():this(new TextOf(string.Empty)){}
        protected EquatableProficiency(ITextOf name){ProficiencyName = name;}
        public override bool Equals(object obj)
        {
            return Equals((EquatableProficiency)obj);
        }

        private bool Equals(EquatableProficiency other)
        {
            return Equals(ProficiencyName, other.ProficiencyName);
        }

        public override int GetHashCode()
        {
            return (ProficiencyName != null ? ProficiencyName.GetHashCode() : 0);
        }

        public static bool operator ==(EquatableProficiency left, EquatableProficiency right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EquatableProficiency left, EquatableProficiency right)
        {
            return !Equals(left, right);
        }
    }
}
