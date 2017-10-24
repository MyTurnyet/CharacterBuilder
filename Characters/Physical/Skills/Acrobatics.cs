using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters.Display;

namespace Characters.Physical.Skills
{
    public class Acrobatics:SkillBase,ISkill
    {
        public Acrobatics():base(new TextOf("Acrobatics")){}
    }
    public class AnimalHandling : SkillBase, ISkill
    {
        public AnimalHandling() : base(new TextOf("Animal Handling")) { }
    }
    public class Arcana : SkillBase, ISkill
    {
        public Arcana() : base(new TextOf("Arcana")) { }
    }
    public class Athletics : SkillBase, ISkill
    {
        public Athletics() : base(new TextOf("Athletics")) { }
    }
    public class Deception : SkillBase, ISkill
    {
        public Deception() : base(new TextOf("Deception")) { }
    }
    public class History : SkillBase, ISkill
    {
        public History() : base(new TextOf("History")) { }
    }
    public class Insight : SkillBase, ISkill
    {
        public Insight() : base(new TextOf("Insight")) { }
    }
    public class Intimidation : SkillBase, ISkill
    {
        public Intimidation() : base(new TextOf("Intimidation")) { }
    }
    public class Investigation : SkillBase, ISkill
    {
        public Investigation() : base(new TextOf("Investigation")) { }
    }
    public class Medicine : SkillBase, ISkill
    {
        public Medicine() : base(new TextOf("Medicine")) { }
    }
    public class Nature : SkillBase, ISkill
    {
        public Nature() : base(new TextOf("Nature")) { }
    }
    public class Perception : SkillBase, ISkill
    {
        public Perception() : base(new TextOf("Perception")) { }
    }
    public class Performance : SkillBase, ISkill
    {
        public Performance() : base(new TextOf("Performance")) { }
    }
    public class Persuassion : SkillBase, ISkill
    {
        public Persuassion() : base(new TextOf("Persuassion")) { }
    }
    public class Religion : SkillBase, ISkill
    {
        public Religion() : base(new TextOf("Religion")) { }
    }
    public class SlightOfHand : SkillBase, ISkill
    {
        public SlightOfHand() : base(new TextOf("Slight Of Hand")) { }
    }
    public class Stealth : SkillBase, ISkill
    {
        public Stealth() : base(new TextOf("Stealth")) { }
    }
    public class Survival : SkillBase, ISkill
    {
        public Survival() : base(new TextOf("Survival")) { }
    }
}
