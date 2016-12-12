using System;

namespace Day08
{
    public class CommandParser
    {
        public ScreenCommand Parse(string command)
        {
            if (command.StartsWith("rect"))
                return ParseRectCommand(command);

            if (command.StartsWith("rotate row"))
                return ParseRotateRowCommand(command);

            if (command.StartsWith("rotate column"))
                return ParseRotateColumnCommand(command);

            throw new NotSupportedException($"Command '{command}' not supported.");
        }

        private static ScreenCommand ParseRectCommand(string command)
        {
            var param = command.Substring(5).Split('x');
            var width = int.Parse(param[0]);
            var height = int.Parse(param[1]);

            return new RectCommand(width, height);
        }

        private static ScreenCommand ParseRotateRowCommand(string command)
        {
            var param = command.Substring(11).Split(new[] {" by "}, StringSplitOptions.None);

            var rowNumber = int.Parse(param[0].Split('=')[1]);
            var count = int.Parse(param[1]);

            return new ShiftRowCommand(rowNumber, count);
        }

        private static ScreenCommand ParseRotateColumnCommand(string command)
        {
            var param = command.Substring(14).Split(new[] { " by " }, StringSplitOptions.None);

            var rowNumber = int.Parse(param[0].Split('=')[1]);
            var count = int.Parse(param[1]);

            return new ShiftColumnCommand(rowNumber, count);
        }
    }
}
