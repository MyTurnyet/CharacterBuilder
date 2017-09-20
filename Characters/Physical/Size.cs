namespace Characters.Physical
{
    public class Size : ISize
    {
        private readonly string _title;
        private readonly int _value;

        public static readonly Size Tiny = new Size("Tiny", 1);
        public static readonly Size Small = new Size("Small", 3);
        public static readonly Size Medium = new Size("Medium", 5);
        public static readonly Size Large = new Size("Large", 7);
        public static readonly Size Huge = new Size("Huge", 11);
        public static readonly Size Gargantuan = new Size("Gargantuan", 13);
        private Size(string title, int value)
        {
            _title = title;
            _value = value;
        }

        public override bool Equals(object obj)
        {
            return (Size)obj != null && Equals((ISize)obj);
        }

        private bool Equals(ISize other)
        {
            return _value == ((Size)other)._value;
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
