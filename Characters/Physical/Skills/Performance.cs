﻿using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Performance : SkillBase, ISkill
    {
        public Performance() : base(new TextObj("Performance"), new CharismaAttribute()) { }
    }
}