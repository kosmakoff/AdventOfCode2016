using Day02.Keypads;

namespace Day02
{
    public class KeypadClicker
    {
        private readonly IKeypad _keypad;

        public KeypadClicker(IKeypad keypad, KeypadButton startButton = KeypadButton.Button5)
        {
            _keypad = keypad;
            CurrentButton = startButton;
        }

        public KeypadButton CurrentButton { get; private set; }

        public void Move(MoveDirection moveDirection)
        {
            CurrentButton = _keypad.GetAdjacentButton(CurrentButton, moveDirection);
        }
    }
}
