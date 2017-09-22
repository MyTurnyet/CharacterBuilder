namespace Characters.Dice
{
    public class Die
    {
        // ReSharper disable InconsistentNaming
        protected readonly int _numberOfSides;
        
        public static readonly Die d4 = new Die(4);
        public static readonly Die d6 = new Die(6);
        public static readonly Die d8 = new Die(8);
        public static readonly Die d10 = new Die(10);
        public static readonly Die d12 = new Die(12);
        public static readonly Die d20 = new Die(20);
        // ReSharper restore InconsistentNaming

        protected Die(int numberOfSides)
        {
            _numberOfSides = numberOfSides;
        }

        public override bool Equals(object obj) => Equals((Die)obj);
        private bool Equals(Die other) => _numberOfSides == other._numberOfSides;
        public override int GetHashCode() => _numberOfSides;
        public static bool operator ==(Die left, Die right) => Equals(left, right);
        public static bool operator !=(Die left, Die right) => !Equals(left, right);
    }
}
