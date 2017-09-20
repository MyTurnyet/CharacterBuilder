namespace Characters.Physical
{
    public class Size
    {
        private readonly string _title;
        private readonly int _value;

        public static Size Tiny = new Size("Tiny",1);
        public static Size Small = new Size("Small",3);
        public static Size Medium = new Size("Medium",5);
        public static Size Large = new Size("Large",7);
        public static Size Huge = new Size("Huge",11);
        public static Size Gargantuan = new Size("Gargantuan", 13);
        private Size(string title, int value)
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
