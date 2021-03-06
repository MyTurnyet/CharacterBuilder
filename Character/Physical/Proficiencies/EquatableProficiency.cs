﻿using Character.Display;

namespace Character.Physical.Proficiencies
{
#pragma warning disable 660,661,659
    public abstract class EquatableProficiency
    {
        protected readonly ITextObj ProficiencyName;
        protected EquatableProficiency(ITextObj name){ProficiencyName = name;}
        public override bool Equals(object obj) => Equals((EquatableProficiency)obj);
        private bool Equals(EquatableProficiency other) => Equals(ProficiencyName, other.ProficiencyName);
        public static bool operator ==(EquatableProficiency left, EquatableProficiency right) => Equals(left, right);
        public static bool operator !=(EquatableProficiency left, EquatableProficiency right) => !Equals(left, right);
#pragma warning restore 660,661,659
    }
}
