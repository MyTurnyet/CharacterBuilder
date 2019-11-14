namespace Character.Dice
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class DieBase
    {
        protected readonly int NumberOfSides;

        protected DieBase(int numberOfSides)
        {
            NumberOfSides = numberOfSides;
        }
        public override bool Equals(object obj) => Equals((DieBase)obj);
        private bool Equals(DieBase other) => NumberOfSides == other.NumberOfSides;
    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
