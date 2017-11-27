using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters.Display;

namespace Characters.Physical.Sizes
{
    public class Small:Size
    {
        public Small() : base(3, new TextObj("Small"))
        {
        }
    }
}
