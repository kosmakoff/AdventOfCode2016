using System.Collections.Generic;

namespace Day02.Keypads
{
    public abstract class KeypadBase : IKeypad
    {
        public abstract IDictionary<KeypadButton, IDictionary<MoveDirection, KeypadButton>> DirectionsMap { get; }

        public KeypadButton GetAdjacentButton(KeypadButton currentButton, MoveDirection direction)
        {
            var dict = DirectionsMap[currentButton];

            KeypadButton newButton;
            if (!dict.TryGetValue(direction, out newButton))
                newButton = currentButton;

            return newButton;
        }
    }
}
