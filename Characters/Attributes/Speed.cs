namespace Characters.Attributes
{
    public class Speed
    {
        private readonly int _distance;

        public Speed(int distance)
        {
            _distance = distance;
        }

        public override bool Equals(object obj) => (Speed)obj != null && ((Speed)obj)._distance == _distance;

        public override int GetHashCode() => _distance;

        public static bool operator ==(Speed left, Speed right) => Equals(left, right);

        public static bool operator !=(Speed left, Speed right) => !Equals(left, right);
        public static Speed operator +(Speed left, Speed right) => new Speed(left._distance + right._distance);
        public static Speed operator -(Speed left, Speed right) => new Speed(left._distance - right._distance);
    }
}
