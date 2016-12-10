using System;
using System.IO;
using System.Linq;
using Day02.Keypads;

namespace Day02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Advent Of Code 2016, day 2");

            var fileName = args[0];

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found");
                return;
            }

            var input = File.ReadAllText(fileName);

            var lines = input.Split('\n');

            var parser = new MoveDirectionParser();

            var clicker = new KeypadClicker(new DiamondKeypad());

            foreach (var line in lines)
            {
                var letters = line.Select(parser.Parse);

                foreach (var moveDirection in letters)
                {
                    clicker.Move(moveDirection);
                }

                Console.WriteLine(clicker.CurrentButton);
            }

            Console.ReadLine();
        }
    }
}
