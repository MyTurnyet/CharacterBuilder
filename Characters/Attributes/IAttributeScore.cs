﻿using Characters.Display;

namespace Characters.Attributes
{
    public interface IAttributeScore
    {
        bool Equals(object obj);
        int Bonus();
        IAttributeScore Add(IAttributeScore scoreToAdd);
        IAttributeScore Subtract(IAttributeScore scoreToSubtract);
        TextObj AsText();
    }
}