﻿namespace Characters.Dice
{
    public class Die : IDie
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
#pragma warning disable 659
        public override bool Equals(object obj) => Equals((Die)obj);
#pragma warning restore 659
        private bool Equals(Die other) => _numberOfSides == other._numberOfSides;
    }
}
