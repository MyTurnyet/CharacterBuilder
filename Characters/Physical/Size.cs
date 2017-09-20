namespace Characters.Physical
{
    public class Size
    {
        private readonly string _title;
        private readonly int _value;

        public Size(string title, int value)
        {
            _title = title;
            _value = value;
        }

        public override bool Equals(object obj)
        {
            return (Size)obj != null && ((Size)obj)._value == _value;
        }

        protected bool Equals(Size other)
        {
            return _value == other._value;
        }

        public override int GetHashCode()
        {
            return _value;
        }

        public static bool operator ==(Size left, Size right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Size left, Size right)
        {
            return !Equals(left, right);
        }

        public static bool operator >(Size left, Size right)
        {
            return left._value > right._value;
        }

        public static bool operator <(Size left, Size right)
        {
            return left._value < right._value;
        }
    }
}
