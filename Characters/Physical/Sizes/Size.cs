using Characters.Display;

namespace Characters.Physical.Sizes
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public abstract class Size : ISize
    {
        private readonly int _value;
        private readonly TextOf _name;

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
