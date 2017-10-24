using Characters.Display;

namespace Characters.Physical.Sizes
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class Size : ISize
    {
        private readonly int _value;
        private readonly TextOf _name;

        //public static readonly Size Tiny = new Size(1,new TextOf("Tiny"));
        //public static readonly Size Small = new Size(3,new TextOf("Small"));
        //public static readonly Size Medium = new Size(5,new TextOf("Medium"));
        //public static readonly Size Large = new Size(7,new TextOf("Large"));
        //public static readonly Size Huge = new Size(11,new TextOf("Huge"));
        //public static readonly Size Gargantuan = new Size(13,new TextOf("Gargantuan"));

        protected Size(int value, TextOf name)
        {
            _value = value;
            _name = name;
        }
        public override bool Equals(object obj) => (Size)obj != null && Equals((ISize)obj);
        private bool Equals(ISize other) => _value == ((Size)other)._value;
        public TextOf Name() => _name;
    }
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
}
