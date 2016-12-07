using System;

namespace Day02
{
    public class MoveDirectionParser
    {
        public MoveDirection Parse(char direction)
        {
            switch (direction)
            {
                case 'U':
                    return MoveDirection.Up;
                case 'D':
                    return MoveDirection.Down;
                case 'L':
                    return MoveDirection.Left;
                case 'R':
                    return MoveDirection.Right;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
