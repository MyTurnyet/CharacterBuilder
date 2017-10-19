using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.Physical.Proficiencies
{
    public class EquateProficiency
    {
        private readonly IProficiency _left;
        private readonly IProficiency _right;
        public EquateProficiency(IProficiency left, IProficiency right)
        {
            _left = left;
            _right = right;
        }
        public bool AreEqual() => _left.Name.Equals(_right.Name);
    }
}
