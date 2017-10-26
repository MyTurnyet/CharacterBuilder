﻿using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Perception : SkillBase, ISkill
    {
        public Perception() : this( new WisdomAttribute()) { }
        public Perception(WisdomAttribute wisdomAttribute) : base(new TextObj("Perception"), wisdomAttribute) { }
    }
}
