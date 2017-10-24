using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters.Display;

namespace Characters.Physical.Sizes
{
    public class Tiny:Size
    {
        public Tiny() : base(1, new TextOf("Tiny")){}
    }
    public class Small:Size
    {
        public Small() : base(3, new TextOf("Small")){}
    }
    public class Medium : Size
    {
        public Medium() : base(5, new TextOf("Medium")){}
    }
    public class Large : Size
    {
        public Large() : base(7, new TextOf("Large")){}
    }
    public class Huge: Size
    {
        public Huge() : base(11, new TextOf("Huge")){ }
    }
    public class Gargantuan : Size
    {
        public Gargantuan() : base(13, new TextOf("Gargantuan")){}
    }
}
