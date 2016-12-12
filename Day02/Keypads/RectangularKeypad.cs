using System.Collections.Generic;

namespace Day02.Keypads
{
    public class RectangularKeypad : KeypadBase
    {
        public override IDictionary<KeypadButton, IDictionary<MoveDirection, KeypadButton>> DirectionsMap => new Dictionary<KeypadButton, IDictionary<MoveDirection, KeypadButton>>
            {
                [KeypadButton.Button1] = new Dictionary<MoveDirection, KeypadButton>
                {
                    [MoveDirection.Down] = KeypadButton.Button4,
                    [MoveDirection.Right] = KeypadButton.Button2
                },
                [KeypadButton.Button2] = new Dictionary<MoveDirection, KeypadButton>
                {
                    [MoveDirection.Down] = KeypadButton.Button5,
                    [MoveDirection.Left] = KeypadButton.Button1,
                    [MoveDirection.Right] = KeypadButton.Button3
                },
                [KeypadButton.Button3] = new Dictionary<MoveDirection, KeypadButton>
                {
                    [MoveDirection.Down] = KeypadButton.Button6,
                    [MoveDirection.Left] = KeypadButton.Button2
                },
                [KeypadButton.Button4] = new Dictionary<MoveDirection, KeypadButton>
                {
                    [MoveDirection.Down] = KeypadButton.Button7,
                    [MoveDirection.Up] = KeypadButton.Button1,
                    [MoveDirection.Right] = KeypadButton.Button5
                },
                [KeypadButton.Button5] = new Dictionary<MoveDirection, KeypadButton>
                {
                    [MoveDirection.Down] = KeypadButton.Button8,
                    [MoveDirection.Up] = KeypadButton.Button2,
                    [MoveDirection.Left] = KeypadButton.Button4,
                    [MoveDirection.Right] = KeypadButton.Button6
                },
                [KeypadButton.Button6] = new Dictionary<MoveDirection, KeypadButton>
                {
                    [MoveDirection.Down] = KeypadButton.Button9,
                    [MoveDirection.Up] = KeypadButton.Button3,
                    [MoveDirection.Left] = KeypadButton.Button5
                },
                [KeypadButton.Button7] = new Dictionary<MoveDirection, KeypadButton>
                {
                    [MoveDirection.Up] = KeypadButton.Button4,
                    [MoveDirection.Right] = KeypadButton.Button8
                },
                [KeypadButton.Button8] = new Dictionary<MoveDirection, KeypadButton>
                {
                    [MoveDirection.Up] = KeypadButton.Button5,
                    [MoveDirection.Left] = KeypadButton.Button7,
                    [MoveDirection.Right] = KeypadButton.Button9
                },
                [KeypadButton.Button9] = new Dictionary<MoveDirection, KeypadButton>
                {
                    [MoveDirection.Up] = KeypadButton.Button6,
                    [MoveDirection.Left] = KeypadButton.Button8,
                }
            };
    }
}
