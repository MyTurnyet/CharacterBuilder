namespace Characters.Physical
{
    public class Size : ISize
    {
        private readonly int _value;

        public static readonly Size Tiny = new Size(1);
        public static readonly Size Small = new Size(3);
        public static readonly Size Medium = new Size(5);
        public static readonly Size Large = new Size(7);
        public static readonly Size Huge = new Size(11);
        public static readonly Size Gargantuan = new Size(13);
        private Size(int value)
        {
            _value = value;
        }

        public override bool Equals(object obj) => (Size)obj != null && Equals((ISize)obj);
        private bool Equals(ISize other) => _value == ((Size)other)._value;
        public static bool operator >(Size left, Size right) => left._value > right._value;
        public static bool operator <(Size left, Size right) => left._value < right._value;
    }
}
