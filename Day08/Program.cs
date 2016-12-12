using System;
using System.Linq;
using Common;

namespace Day08
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Advent Of Code 2016, day 8");

            var input = InputUtils.GetInput(args).ReadToEnd();

            var commandParser = new CommandParser();

            var commands = input.Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(commandParser.Parse);

            var screen = new Screen(50, 6);

            foreach (var screenCommand in commands)
            {
                screenCommand.Execute(screen);
            }

            Console.WriteLine(screen);

            Console.WriteLine($"Bits turned on: {screen.ScreenBits.Cast<bool>().Count(x => x)}");
        }
    }
}
