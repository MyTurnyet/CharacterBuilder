﻿using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Investigation : SkillBase, ISkill
    {
        public Investigation() : this( new IntellegenceAttribute()) { }
        public Investigation(IntellegenceAttribute intellegenceAttribute) : base(new TextObj("Investigation"), intellegenceAttribute) { }
    }
}
