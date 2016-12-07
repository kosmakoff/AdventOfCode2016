namespace Day02.Keypads
{
    public interface IKeypad
    {
        KeypadButton GetAdjacentButton(KeypadButton currentButton, MoveDirection direction);
    }
}
