namespace Characters.Display
{
    public interface ITextObjAppendable
    {
        ITextObj Append(ITextObj textObjAppend);
        ITextObj Append(ITextObjAppendable textObjAppend);
    }
}