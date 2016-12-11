using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Day08
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Advent Of Code 2016, day 8");

            var fileName = args[0];

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found");
                return;
            }

            var input = File.ReadAllText(fileName);

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
