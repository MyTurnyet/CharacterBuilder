namespace Characters.Physical
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class Speed : ISpeed
    {
        private readonly int _distance;

        public Speed(int distance)
        {
            _distance = distance;
        }

        public override bool Equals(object obj) => (Speed)obj != null && ((Speed)obj)._distance == _distance;
        public ISpeed Add(ISpeed speedToAdd)
        {
            return new Speed(_distance + ((Speed)speedToAdd)._distance);
        }
    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
