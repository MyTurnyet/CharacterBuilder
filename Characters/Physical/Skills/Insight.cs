﻿using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Insight : SkillBase, ISkill
    {
        public Insight() : this(new WisdomAttribute()) { }
        public Insight(WisdomAttribute wisdomAttribute) : base(new TextObj("Insight"), wisdomAttribute) { }
    }
}
