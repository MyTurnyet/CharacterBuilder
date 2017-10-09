namespace Characters.Physical
{
    public class Speed : ISpeed
    {
        private readonly int _distance;

        public Speed(int distance)
        {
            _distance = distance;
        }

        public override bool Equals(object obj) => (Speed)obj != null && ((Speed)obj)._distance == _distance;
        public static Speed operator +(Speed left, Speed right) => new Speed(left._distance + right._distance);
    }
}
