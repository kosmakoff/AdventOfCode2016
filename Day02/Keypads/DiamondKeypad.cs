using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day02.Keypads
{
    public class DiamondKeypad : KeypadBase
    {
        public override IDictionary<KeypadButton, IDictionary<MoveDirection, KeypadButton>> DirectionsMap => new Dictionary<KeypadButton, IDictionary<MoveDirection, KeypadButton>>
        {
            [KeypadButton.Button1] = new Dictionary<MoveDirection, KeypadButton>
            {
                [MoveDirection.Down] = KeypadButton.Button3
            },
            [KeypadButton.Button2] = new Dictionary<MoveDirection, KeypadButton>
            {
                [MoveDirection.Down] = KeypadButton.Button6,
                [MoveDirection.Right] = KeypadButton.Button3
            },
            [KeypadButton.Button3] = new Dictionary<MoveDirection, KeypadButton>
            {
                [MoveDirection.Up] = KeypadButton.Button1,
                [MoveDirection.Down] = KeypadButton.Button7,
                [MoveDirection.Left] = KeypadButton.Button2,
                [MoveDirection.Right] = KeypadButton.Button4
            },
            [KeypadButton.Button4] = new Dictionary<MoveDirection, KeypadButton>
            {
                [MoveDirection.Left] = KeypadButton.Button3,
                [MoveDirection.Down] = KeypadButton.Button8
            },
            [KeypadButton.Button5] = new Dictionary<MoveDirection, KeypadButton>
            {
                [MoveDirection.Right] = KeypadButton.Button6
            },
            [KeypadButton.Button6] = new Dictionary<MoveDirection, KeypadButton>
            {
                [MoveDirection.Up] = KeypadButton.Button2,
                [MoveDirection.Down] = KeypadButton.ButtonA,
                [MoveDirection.Left] = KeypadButton.Button5,
                [MoveDirection.Right] = KeypadButton.Button7
            },
            [KeypadButton.Button7] = new Dictionary<MoveDirection, KeypadButton>
            {
                [MoveDirection.Up] = KeypadButton.Button3,
                [MoveDirection.Down] = KeypadButton.ButtonB,
                [MoveDirection.Left] = KeypadButton.Button6,
                [MoveDirection.Right] = KeypadButton.Button8
            },
            [KeypadButton.Button8] = new Dictionary<MoveDirection, KeypadButton>
            {
                [MoveDirection.Up] = KeypadButton.Button4,
                [MoveDirection.Down] = KeypadButton.ButtonC,
                [MoveDirection.Left] = KeypadButton.Button7,
                [MoveDirection.Right] = KeypadButton.Button9
            },
            [KeypadButton.Button9] = new Dictionary<MoveDirection, KeypadButton>
            {
                [MoveDirection.Left] = KeypadButton.Button8
            },
            [KeypadButton.ButtonA] = new Dictionary<MoveDirection, KeypadButton>
            {
                [MoveDirection.Up] = KeypadButton.Button6,
                [MoveDirection.Right] = KeypadButton.ButtonB
            },
            [KeypadButton.ButtonB] = new Dictionary<MoveDirection, KeypadButton>
            {
                [MoveDirection.Up] = KeypadButton.Button7,
                [MoveDirection.Down] = KeypadButton.ButtonD,
                [MoveDirection.Left] = KeypadButton.ButtonA,
                [MoveDirection.Right] = KeypadButton.ButtonC
            },
            [KeypadButton.ButtonC] = new Dictionary<MoveDirection, KeypadButton>
            {
                [MoveDirection.Up] = KeypadButton.Button8,
                [MoveDirection.Left] = KeypadButton.ButtonB
            },
            [KeypadButton.ButtonD] = new Dictionary<MoveDirection, KeypadButton>
            {
                [MoveDirection.Up] = KeypadButton.ButtonB
            }
        };
    }
}
