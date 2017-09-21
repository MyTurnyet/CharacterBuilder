using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Die
    {
        private readonly int _numberOfSides;

        public Die(int numberOfSides)
        {
            this._numberOfSides = numberOfSides;
        }

        public override bool Equals(object obj)
        {
            return Equals((Die)obj);
        }

        private bool Equals(Die other)
        {
            return _numberOfSides == other._numberOfSides;
        }

        public override int GetHashCode()
        {
            return _numberOfSides;
        }

        public static bool operator ==(Die left, Die right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Die left, Die right)
        {
            return !Equals(left, right);
        }
    }
}
