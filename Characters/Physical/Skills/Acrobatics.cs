﻿using Characters.Attributes;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Acrobatics:SkillBase,ISkill
    {
        public Acrobatics():base(new TextObj("Acrobatics"),new DexterityAttribute()){}

    }
}