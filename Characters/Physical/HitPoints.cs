using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.Physical
{
    public class HitPoints
    {
        private readonly int _hpValue;

        public HitPoints(int value)
        {
            _hpValue = value;
        }

        public override bool Equals(object obj)
        {
            return obj != null && Equals((HitPoints)obj);
        }

        private bool Equals(HitPoints other)
        {
            return _hpValue == other._hpValue;
        }

        public override int GetHashCode()
        {
            return _hpValue;
        }

        public static bool operator ==(HitPoints left, HitPoints right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(HitPoints left, HitPoints right)
        {
            return !Equals(left, right);
        }

        public static HitPoints operator +(HitPoints left, HitPoints right)
        {
            return new HitPoints(left._hpValue + right._hpValue);
        }
        public static HitPoints operator -(HitPoints left, HitPoints right)
        {
            return new HitPoints(left._hpValue - right._hpValue);
        }

        public static HitPoints operator +(HitPoints left, int right)
        {
            return new HitPoints(left._hpValue + right);
        }
        public static HitPoints operator -(HitPoints left, int right)
        {
            return new HitPoints(left._hpValue - right);
        }
    }
}
